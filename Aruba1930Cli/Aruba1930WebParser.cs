using Aruba1930Cli.Dto;
using Aruba1930Cli.DTO;
using Aruba1930Cli.XMLGenerated;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Security.Authentication;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Aruba1930Cli
{
    public class Aruba1930WebParser
    {
        private HttpClient ApiClient { get; }
        private CookieContainer CookieContainer { get; }

        public Aruba1930WebParser(string baseAddress)
        {
            CookieContainer = new();

            var handler = new HttpClientHandler
            {
                CookieContainer = CookieContainer,
                UseCookies = true,
                UseDefaultCredentials = false,
            };

            ApiClient = new(handler)
            {
                BaseAddress = new Uri(baseAddress)
            };
        }

        async protected Task<EncryptionSettings> EncryptionSettingsGet()
        {
            var uri = new Uri(ApiClient.BaseAddress!, "device/wcd?{EncryptionSetting}");
            var streamTask = await ApiClient.GetStreamAsync(uri);//.UncanonicQueryString());

            var ser = new XmlSerializer(typeof(ResponseDataEncriptionSettings));
            var rd = (ResponseDataEncriptionSettings?)ser?.Deserialize(streamTask) ??
                throw new SerializationException("Deserialization error... Object is empty"); ;

            return new EncryptionSettings
            {
                PasswEncryptEnable = rd.DeviceConfiguration.EncryptionSetting.passwEncryptEnable == 1,
                RsaPublicKey = rd.DeviceConfiguration.EncryptionSetting.rsaPublicKey,
                LoginToken = rd.DeviceConfiguration.EncryptionSetting.loginToken
            };
        }

        async public Task Login(string userName, string userPass)
        {
            var encSettings = await EncryptionSettingsGet();

            if (encSettings.PasswEncryptEnable)
            {
                byte[] certBytes = Convert.FromBase64String(
                    encSettings
                        .RsaPublicKey
                        .Replace("-----BEGIN RSA PUBLIC KEY-----", "")
                        .Replace("-----END RSA PUBLIC KEY-----", ""));

                var rsa = RSA.Create();
                rsa.ImportRSAPublicKey(certBytes, out _);

                // reverse engineering from Aruba JS-code: BASE_ADDRESS/csbf9485b5/hpe/config/login.htm
                // var res = rsa.encrypt("user=" + username + "&password=" + password + "&ssd=true" + "&token=" + loginToken +"&" );
                var encData = rsa.Encrypt(Encoding.ASCII.GetBytes($"user={userName}&password={userPass}&ssd=true&token={encSettings.LoginToken}&"), RSAEncryptionPadding.Pkcs1);

                var uri = new Uri(ApiClient.BaseAddress!, $"/csbf9485b5/hpe/config/system.xml?action=login&cred={Convert.ToHexString(encData).ToLower()}");

                var response = await ApiClient.GetAsync(uri);
                if (!response.IsSuccessStatusCode)
                    throw new AuthenticationException(response.ReasonPhrase);

                var streamTask = await response.Content.ReadAsStreamAsync();

                var ser = new XmlSerializer(typeof(ResponseDataLogin));
                var rd = (ResponseDataLogin?)ser?.Deserialize(streamTask) ??
                    throw new SerializationException("Deserialization error... Object is empty"); ;

                if (rd.ActionStatus.statusCode == "0")
                    return;

                throw new AuthenticationException(rd.ActionStatus.statusString);
            }

            // not secure login/password - not implemented yet
            //var newPath = './system.xml?action=login&user=' + username + '&password=' + password + "&ssd=true&";
            throw new NotImplementedException();
        }

        async public Task<(UnitStatus, UnitStatusPoE, UnitPort[], UnitPortPoE[], UnitPortStatistics[])> GetAllStatuses()
        {
            var uri = new Uri(ApiClient.BaseAddress!, "device/wcd?{Ports}{DiagnosticsUnitList}{PoEPSEInterfaceList}{PoEPSEUnitList}{RMONStatistics}");

            var streamTask = await ApiClient.GetStreamAsync(uri);//.UncanonicQueryString());

            var ser = new XmlSerializer(typeof(ResponseData));
            var rd = (ResponseData?)ser?.Deserialize(streamTask) ??
                throw new SerializationException("Deserialization error... Object is empty"); ;

            var us = new UnitStatus
            {
                TemperatureSensorValue = rd.DeviceConfiguration.DiagnosticsUnitList.Entry.tempSensorValue,
                TemperatureSensorStatus = rd.DeviceConfiguration.DiagnosticsUnitList.Entry.tempSensorStatus,
                SystemUpTime = TimeSpan.FromSeconds(rd.DeviceConfiguration.DiagnosticsUnitList.Entry.upTime / 100)
            };

            var usp = new UnitStatusPoE
            {
                PoEStatus = rd.DeviceConfiguration.PoEPSEUnitList.UnitEntry.operStatus,
                PowerTotal = rd.DeviceConfiguration.PoEPSEUnitList.UnitEntry.nominalPower, // watts
                PowerConsumption = rd.DeviceConfiguration.PoEPSEUnitList.UnitEntry.consumptionPower, // watts
            };

            var up = rd.DeviceConfiguration.Ports.data.portsDataBase.inBandPortTable.Select(e => new UnitPort
            {
                PoESupported = e.POESupported == 1,
                InterfaceIndex = e.ifIndex,
                PortName = e.portName,
                Column = int.TryParse(e.column, out _) ? int.Parse(e.column) : null,
                TransportType = (PortTransportType)e.transType,
                Speed = (PortSpeed)e.ifSpeed,
                LinkStatus = (PortLinkStatus)e.operStatus,
                AdminMode = e.adminStatus == 1

            }).ToArray();

            var upp = rd.DeviceConfiguration.PoEPSEInterfaceList.Interface.Select(e => new UnitPortPoE
            {
                InterfaceIndex = e.interfaceID,
                PortName = e.interfaceName,
                AdminEnable = e.adminEnable == 1,
                PoEStatus = (PortPoEStatus)e.detectionStatus,
                PowerPriority = (PortPowerPriority)e.powerPriority,
                PowerClass = (PortPowerClass)e.powerClassification,
                EventCounters = new PortEventCounters
                {
                    Overloads = e.overLoadCounter,
                    Denials = e.powerDeniedCounter,
                    Absences = e.absentCounter,
                    Shorts = e.shortCounter,
                    InvalidSignatures = e.invalidSignatureCounter
                },
                OutputVoltage = e.outputVoltage / 1000m, // volts
                OutputCurrrent = e.outputCurrent, // mAmps
                PowerLimit = e.powerLimit / 1000m, // watts per port
                MaxPowerAllocation = e.maxPowerAllocAllowed / 1000m, // watts
                NegotiatedPower = e.negotiationAllocatedPower / 1000m, // watts
                OutputPower = e.outputPower / 1000m, // watts
            }).ToArray();

            var ups = rd.DeviceConfiguration.RMONStatistics.InterfaceStatisticsList.Select(e => new UnitPortStatistics
            {
                PortName = e.interfaceName,
                InterfaceIndex = e.interfaceID,
                DropEventCount = e.dropEventCount,
                ReceivePacketByteCount = e.receivePacketByteCount,
                ReceivePacketCount = e.receivePacketCount,
                ReceiveBroadcastPacketCount = e.receiveBroadcastPacketCount,
                ReceiveMulticastPacketCount = e.receiveMulticastPacketCount,
                CRCAlignErrorCount = e.CRCAlignErrorCount,
                UndersizePacketCount = e.undersizePacketCount,
                OversizePacketCount = e.oversizePacketCount,
                FragmentCount = e.fragmentCount,
                JabberCount = e.jabberCount,
                CollisionCount = e.collisionCount,
                FrameOf64BytesCount = e.frameOf64BytesCount,
                FrameOf65To127BytesCount = e.frameOf65To127BytesCount,
                FrameOf128To255BytesCount = e.frameOf128To255BytesCount,
                FrameOf256To511BytesCount = e.frameOf256To511BytesCount,
                FrameOf512To1023BytesCount = e.frameOf512To1023BytesCount,
                FrameOf1024To1518BytesCount = e.frameOf1024To1518BytesCount
            }).ToArray();

            return (us, usp, up, upp, ups);
        }
    }
}
