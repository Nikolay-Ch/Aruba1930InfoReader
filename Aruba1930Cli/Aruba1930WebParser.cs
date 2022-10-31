using Aruba1930Cli.Dto;
using Aruba1930Cli.DTO;
using Aruba1930Cli.XMLGenerated;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Security.Authentication;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Aruba1930Cli
{
    public static class UriExtensions
    {
        public static Uri UncanonicQueryString(this Uri uri)
        {
            var uriType = uri.GetType();

            var flagsEnumType = uriType.GetNestedType("Flags", BindingFlags.NonPublic | BindingFlags.Instance);

            var fieldEnum = uriType.GetField("_flags", BindingFlags.NonPublic | BindingFlags.Instance);

            var val = fieldEnum.GetValue(uri);

            var valCorr = Enum.Parse(flagsEnumType,
                string.Join(", ",
                Enum.Format(flagsEnumType, val, "g")
                    .Split(',', ' ')
                    .Where(e => !string.IsNullOrEmpty(e) && e != "E_QueryNotCanonical")));

            fieldEnum.SetValue(uri, valCorr);

            var s = uri.PathAndQuery;

            var fieldInfo = uriType.GetField("_info", BindingFlags.NonPublic | BindingFlags.Instance);
            var valInfo = fieldInfo.GetValue(uri);
            
            var fieldPathAndQuery = valInfo.GetType().GetField("PathAndQuery", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
            var valPathAndQuery = ((string)fieldPathAndQuery.GetValue(valInfo)).Replace("%7B", "{").Replace("%7D", "}");
            fieldPathAndQuery.SetValue(valInfo, valPathAndQuery);

            return uri;
        }
    }

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
            var uri = new Uri(ApiClient.BaseAddress, "device/wcd?{EncryptionSetting}");
            var streamTask = await ApiClient.GetStreamAsync(uri.UncanonicQueryString());

            var ser = new XmlSerializer(typeof(ResponseDataEncriptionSettings));
            var rd = (ResponseDataEncriptionSettings)ser.Deserialize(streamTask);

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

                // reverse engenereeng from Aruba JS-code: BASE_ADDRESS/csbf9485b5/hpe/config/login.htm
                // var res = rsa.encrypt("user=" + username + "&password=" + password + "&ssd=true" + "&token=" + loginToken +"&" );
                var encData = rsa.Encrypt(Encoding.ASCII.GetBytes($"user={userName}&password={userPass}&ssd=true&token={encSettings.LoginToken}&"), RSAEncryptionPadding.Pkcs1);

                var uri = new Uri(ApiClient.BaseAddress, $"/csbf9485b5/hpe/config/system.xml?action=login&cred={Convert.ToHexString(encData).ToLower()}");

                var response = await ApiClient.GetAsync(uri);
                if (!response.IsSuccessStatusCode)
                    throw new AuthenticationException(response.ReasonPhrase);

                var streamTask = await response.Content.ReadAsStreamAsync();

                var ser = new XmlSerializer(typeof(ResponseDataLogin));
                var rd = (ResponseDataLogin)ser.Deserialize(streamTask);

                if (rd.ActionStatus.statusCode == "0")
                    return;

                throw new AuthenticationException(rd.ActionStatus.statusString);
            }

            // not secure login/password - not implemented yet
            //var newPath = './system.xml?action=login&user=' + username + '&password=' + password + "&ssd=true&";
            throw new NotImplementedException();
        }

        async public Task<(UnitStatus, UnitStatusPoE, UnitPort[], UnitPortPoE[])> GetAllStatuses()
        {
            var uri = new Uri(ApiClient.BaseAddress, "device/wcd?{Ports}{DiagnosticsUnitList}{PoEPSEInterfaceList}{PoEPSEUnitList}");

            var streamTask = await ApiClient.GetStreamAsync(uri.UncanonicQueryString());

            var ser = new XmlSerializer(typeof(ResponseDataAllStatuses));
            var rd = (ResponseDataAllStatuses)ser.Deserialize(streamTask);

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

            return (us, usp, up, upp);
        }
    }
}
