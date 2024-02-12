#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable IDE1006 // Naming Styles
namespace Aruba1930Cli.XMLGenerated
{
    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class ResponseData
    {

        private ResponseDataDeviceConfiguration deviceConfigurationField;

        private ResponseDataActionStatus actionStatusField;

        /// <remarks/>
        public ResponseDataDeviceConfiguration DeviceConfiguration
        {
            get
            {
                return this.deviceConfigurationField;
            }
            set
            {
                this.deviceConfigurationField = value;
            }
        }

        /// <remarks/>
        public ResponseDataActionStatus ActionStatus
        {
            get
            {
                return this.actionStatusField;
            }
            set
            {
                this.actionStatusField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ResponseDataDeviceConfiguration
    {

        private decimal versionField;

        private ResponseDataDeviceConfigurationPorts portsField;

        private ResponseDataDeviceConfigurationDiagnosticsUnitList diagnosticsUnitListField;

        private ResponseDataDeviceConfigurationPoEPSEInterfaceList poEPSEInterfaceListField;

        private ResponseDataDeviceConfigurationPoEPSEUnitList poEPSEUnitListField;

        private ResponseDataDeviceConfigurationRMONStatistics rMONStatisticsField;

        /// <remarks/>
        public decimal version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        public ResponseDataDeviceConfigurationPorts Ports
        {
            get
            {
                return this.portsField;
            }
            set
            {
                this.portsField = value;
            }
        }

        /// <remarks/>
        public ResponseDataDeviceConfigurationDiagnosticsUnitList DiagnosticsUnitList
        {
            get
            {
                return this.diagnosticsUnitListField;
            }
            set
            {
                this.diagnosticsUnitListField = value;
            }
        }

        /// <remarks/>
        public ResponseDataDeviceConfigurationPoEPSEInterfaceList PoEPSEInterfaceList
        {
            get
            {
                return this.poEPSEInterfaceListField;
            }
            set
            {
                this.poEPSEInterfaceListField = value;
            }
        }

        /// <remarks/>
        public ResponseDataDeviceConfigurationPoEPSEUnitList PoEPSEUnitList
        {
            get
            {
                return this.poEPSEUnitListField;
            }
            set
            {
                this.poEPSEUnitListField = value;
            }
        }

        /// <remarks/>
        public ResponseDataDeviceConfigurationRMONStatistics RMONStatistics
        {
            get
            {
                return this.rMONStatisticsField;
            }
            set
            {
                this.rMONStatisticsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ResponseDataDeviceConfigurationPorts
    {

        private ResponseDataDeviceConfigurationPortsData dataField;

        private string typeField;

        /// <remarks/>
        public ResponseDataDeviceConfigurationPortsData data
        {
            get
            {
                return this.dataField;
            }
            set
            {
                this.dataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ResponseDataDeviceConfigurationPortsData
    {

        private ResponseDataDeviceConfigurationPortsDataPortsDataBase portsDataBaseField;

        /// <remarks/>
        public ResponseDataDeviceConfigurationPortsDataPortsDataBase portsDataBase
        {
            get
            {
                return this.portsDataBaseField;
            }
            set
            {
                this.portsDataBaseField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ResponseDataDeviceConfigurationPortsDataPortsDataBase
    {

        private byte rlStackUnitModeField;

        private byte numberOfPortsField;

        private ResponseDataDeviceConfigurationPortsDataPortsDataBasePort[] inBandPortTableField;

        private object outOfBandPortTableField;

        /// <remarks/>
        public byte rlStackUnitMode
        {
            get
            {
                return this.rlStackUnitModeField;
            }
            set
            {
                this.rlStackUnitModeField = value;
            }
        }

        /// <remarks/>
        public byte numberOfPorts
        {
            get
            {
                return this.numberOfPortsField;
            }
            set
            {
                this.numberOfPortsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("port", IsNullable = false)]
        public ResponseDataDeviceConfigurationPortsDataPortsDataBasePort[] inBandPortTable
        {
            get
            {
                return this.inBandPortTableField;
            }
            set
            {
                this.inBandPortTableField = value;
            }
        }

        /// <remarks/>
        public object outOfBandPortTable
        {
            get
            {
                return this.outOfBandPortTableField;
            }
            set
            {
                this.outOfBandPortTableField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ResponseDataDeviceConfigurationPortsDataPortsDataBasePort
    {

        private byte pOESupportedField;

        private ushort ifIndexField;

        private string portNameField;

        private string rowField;

        private string columnField;

        private string relUnitField;

        private byte transTypeField;

        private ushort ifSpeedField;

        private byte swIfTypeField;

        private byte operStatusField;

        private byte adminStatusField;

        private byte suspStatusField;

        /// <remarks/>
        public byte POESupported
        {
            get
            {
                return this.pOESupportedField;
            }
            set
            {
                this.pOESupportedField = value;
            }
        }

        /// <remarks/>
        public ushort ifIndex
        {
            get
            {
                return this.ifIndexField;
            }
            set
            {
                this.ifIndexField = value;
            }
        }

        /// <remarks/>
        public string portName
        {
            get
            {
                return this.portNameField;
            }
            set
            {
                this.portNameField = value;
            }
        }

        /// <remarks/>
        public string row
        {
            get
            {
                return this.rowField;
            }
            set
            {
                this.rowField = value;
            }
        }

        /// <remarks/>
        public string column
        {
            get
            {
                return this.columnField;
            }
            set
            {
                this.columnField = value;
            }
        }

        /// <remarks/>
        public string relUnit
        {
            get
            {
                return this.relUnitField;
            }
            set
            {
                this.relUnitField = value;
            }
        }

        /// <remarks/>
        public byte transType
        {
            get
            {
                return this.transTypeField;
            }
            set
            {
                this.transTypeField = value;
            }
        }

        /// <remarks/>
        public ushort ifSpeed
        {
            get
            {
                return this.ifSpeedField;
            }
            set
            {
                this.ifSpeedField = value;
            }
        }

        /// <remarks/>
        public byte swIfType
        {
            get
            {
                return this.swIfTypeField;
            }
            set
            {
                this.swIfTypeField = value;
            }
        }

        /// <remarks/>
        public byte operStatus
        {
            get
            {
                return this.operStatusField;
            }
            set
            {
                this.operStatusField = value;
            }
        }

        /// <remarks/>
        public byte adminStatus
        {
            get
            {
                return this.adminStatusField;
            }
            set
            {
                this.adminStatusField = value;
            }
        }

        /// <remarks/>
        public byte suspStatus
        {
            get
            {
                return this.suspStatusField;
            }
            set
            {
                this.suspStatusField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ResponseDataDeviceConfigurationDiagnosticsUnitList
    {

        private ResponseDataDeviceConfigurationDiagnosticsUnitListEntry entryField;

        private string typeField;

        /// <remarks/>
        public ResponseDataDeviceConfigurationDiagnosticsUnitListEntry Entry
        {
            get
            {
                return this.entryField;
            }
            set
            {
                this.entryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ResponseDataDeviceConfigurationDiagnosticsUnitListEntry
    {

        private byte fanFailLEDTypeField;

        private byte fanFailLEDColourField;

        private byte unitIDField;

        private byte mainPSStatusField;

        private byte redundantPSStatusField;

        private byte fan1StatusField;

        private byte fan2StatusField;

        private byte fan3StatusField;

        private byte fan4StatusField;

        private byte fan5StatusField;

        private byte fan6StatusField;

        private byte tempSensorValueField;

        private byte tempSensorStatusField;

        private uint upTimeField;

        private byte temperatureStatusField;

        private byte connect1Field;

        private byte connect2Field;

        private byte[] mainPowerSupplyStatusField;

        /// <remarks/>
        public byte fanFailLEDType
        {
            get
            {
                return this.fanFailLEDTypeField;
            }
            set
            {
                this.fanFailLEDTypeField = value;
            }
        }

        /// <remarks/>
        public byte fanFailLEDColour
        {
            get
            {
                return this.fanFailLEDColourField;
            }
            set
            {
                this.fanFailLEDColourField = value;
            }
        }

        /// <remarks/>
        public byte unitID
        {
            get
            {
                return this.unitIDField;
            }
            set
            {
                this.unitIDField = value;
            }
        }

        /// <remarks/>
        public byte mainPSStatus
        {
            get
            {
                return this.mainPSStatusField;
            }
            set
            {
                this.mainPSStatusField = value;
            }
        }

        /// <remarks/>
        public byte redundantPSStatus
        {
            get
            {
                return this.redundantPSStatusField;
            }
            set
            {
                this.redundantPSStatusField = value;
            }
        }

        /// <remarks/>
        public byte fan1Status
        {
            get
            {
                return this.fan1StatusField;
            }
            set
            {
                this.fan1StatusField = value;
            }
        }

        /// <remarks/>
        public byte fan2Status
        {
            get
            {
                return this.fan2StatusField;
            }
            set
            {
                this.fan2StatusField = value;
            }
        }

        /// <remarks/>
        public byte fan3Status
        {
            get
            {
                return this.fan3StatusField;
            }
            set
            {
                this.fan3StatusField = value;
            }
        }

        /// <remarks/>
        public byte fan4Status
        {
            get
            {
                return this.fan4StatusField;
            }
            set
            {
                this.fan4StatusField = value;
            }
        }

        /// <remarks/>
        public byte fan5Status
        {
            get
            {
                return this.fan5StatusField;
            }
            set
            {
                this.fan5StatusField = value;
            }
        }

        /// <remarks/>
        public byte fan6Status
        {
            get
            {
                return this.fan6StatusField;
            }
            set
            {
                this.fan6StatusField = value;
            }
        }

        /// <remarks/>
        public byte tempSensorValue
        {
            get
            {
                return this.tempSensorValueField;
            }
            set
            {
                this.tempSensorValueField = value;
            }
        }

        /// <remarks/>
        public byte tempSensorStatus
        {
            get
            {
                return this.tempSensorStatusField;
            }
            set
            {
                this.tempSensorStatusField = value;
            }
        }

        /// <remarks/>
        public uint upTime
        {
            get
            {
                return this.upTimeField;
            }
            set
            {
                this.upTimeField = value;
            }
        }

        /// <remarks/>
        public byte temperatureStatus
        {
            get
            {
                return this.temperatureStatusField;
            }
            set
            {
                this.temperatureStatusField = value;
            }
        }

        /// <remarks/>
        public byte connect1
        {
            get
            {
                return this.connect1Field;
            }
            set
            {
                this.connect1Field = value;
            }
        }

        /// <remarks/>
        public byte connect2
        {
            get
            {
                return this.connect2Field;
            }
            set
            {
                this.connect2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mainPowerSupplyStatus")]
        public byte[] mainPowerSupplyStatus
        {
            get
            {
                return this.mainPowerSupplyStatusField;
            }
            set
            {
                this.mainPowerSupplyStatusField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ResponseDataDeviceConfigurationPoEPSEInterfaceList
    {

        private ResponseDataDeviceConfigurationPoEPSEInterfaceListInterface[] interfaceField;

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Interface")]
        public ResponseDataDeviceConfigurationPoEPSEInterfaceListInterface[] Interface
        {
            get
            {
                return this.interfaceField;
            }
            set
            {
                this.interfaceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ResponseDataDeviceConfigurationPoEPSEInterfaceListInterface
    {

        private string interfaceNameField;

        private byte interfaceTypeField;

        private byte interfaceIDField;

        private byte unitIDField;

        private byte adminEnableField;

        private byte detectionStatusField;

        private object poweredDeviceField;

        private byte powerPriorityField;

        private byte powerClassificationField;

        private uint absentCounterField;

        private uint invalidSignatureCounterField;

        private uint powerDeniedCounterField;

        private uint overLoadCounterField;

        private uint shortCounterField;

        private ushort outputVoltageField;

        private byte outputCurrentField;

        private ushort outputPowerField;

        private ushort powerLimitField;

        private ushort maxPowerAllocAllowedField;

        private byte supportedPoeTypeField;

        private object timeRangeNameField;

        private byte fourPairForcedField;

        private byte negotiationAllocatedPowerField;

        private byte negotiationProtocolOwnerField;

        private byte hardwareStatusField;

        private byte portLegacy_powerDetectTypeField;

        private byte powerManagementModeField;

        private byte portClassLimitField;

        /// <remarks/>
        public string interfaceName
        {
            get
            {
                return this.interfaceNameField;
            }
            set
            {
                this.interfaceNameField = value;
            }
        }

        /// <remarks/>
        public byte interfaceType
        {
            get
            {
                return this.interfaceTypeField;
            }
            set
            {
                this.interfaceTypeField = value;
            }
        }

        /// <remarks/>
        public byte interfaceID
        {
            get
            {
                return this.interfaceIDField;
            }
            set
            {
                this.interfaceIDField = value;
            }
        }

        /// <remarks/>
        public byte unitID
        {
            get
            {
                return this.unitIDField;
            }
            set
            {
                this.unitIDField = value;
            }
        }

        /// <remarks/>
        public byte adminEnable
        {
            get
            {
                return this.adminEnableField;
            }
            set
            {
                this.adminEnableField = value;
            }
        }

        /// <remarks/>
        public byte detectionStatus
        {
            get
            {
                return this.detectionStatusField;
            }
            set
            {
                this.detectionStatusField = value;
            }
        }

        /// <remarks/>
        public object poweredDevice
        {
            get
            {
                return this.poweredDeviceField;
            }
            set
            {
                this.poweredDeviceField = value;
            }
        }

        /// <remarks/>
        public byte powerPriority
        {
            get
            {
                return this.powerPriorityField;
            }
            set
            {
                this.powerPriorityField = value;
            }
        }

        /// <remarks/>
        public byte powerClassification
        {
            get
            {
                return this.powerClassificationField;
            }
            set
            {
                this.powerClassificationField = value;
            }
        }

        /// <remarks/>
        public uint absentCounter
        {
            get
            {
                return this.absentCounterField;
            }
            set
            {
                this.absentCounterField = value;
            }
        }

        /// <remarks/>
        public uint invalidSignatureCounter
        {
            get
            {
                return this.invalidSignatureCounterField;
            }
            set
            {
                this.invalidSignatureCounterField = value;
            }
        }

        /// <remarks/>
        public uint powerDeniedCounter
        {
            get
            {
                return this.powerDeniedCounterField;
            }
            set
            {
                this.powerDeniedCounterField = value;
            }
        }

        /// <remarks/>
        public uint overLoadCounter
        {
            get
            {
                return this.overLoadCounterField;
            }
            set
            {
                this.overLoadCounterField = value;
            }
        }

        /// <remarks/>
        public uint shortCounter
        {
            get
            {
                return this.shortCounterField;
            }
            set
            {
                this.shortCounterField = value;
            }
        }

        /// <remarks/>
        public ushort outputVoltage
        {
            get
            {
                return this.outputVoltageField;
            }
            set
            {
                this.outputVoltageField = value;
            }
        }

        /// <remarks/>
        public byte outputCurrent
        {
            get
            {
                return this.outputCurrentField;
            }
            set
            {
                this.outputCurrentField = value;
            }
        }

        /// <remarks/>
        public ushort outputPower
        {
            get
            {
                return this.outputPowerField;
            }
            set
            {
                this.outputPowerField = value;
            }
        }

        /// <remarks/>
        public ushort powerLimit
        {
            get
            {
                return this.powerLimitField;
            }
            set
            {
                this.powerLimitField = value;
            }
        }

        /// <remarks/>
        public ushort maxPowerAllocAllowed
        {
            get
            {
                return this.maxPowerAllocAllowedField;
            }
            set
            {
                this.maxPowerAllocAllowedField = value;
            }
        }

        /// <remarks/>
        public byte supportedPoeType
        {
            get
            {
                return this.supportedPoeTypeField;
            }
            set
            {
                this.supportedPoeTypeField = value;
            }
        }

        /// <remarks/>
        public object timeRangeName
        {
            get
            {
                return this.timeRangeNameField;
            }
            set
            {
                this.timeRangeNameField = value;
            }
        }

        /// <remarks/>
        public byte fourPairForced
        {
            get
            {
                return this.fourPairForcedField;
            }
            set
            {
                this.fourPairForcedField = value;
            }
        }

        /// <remarks/>
        public byte negotiationAllocatedPower
        {
            get
            {
                return this.negotiationAllocatedPowerField;
            }
            set
            {
                this.negotiationAllocatedPowerField = value;
            }
        }

        /// <remarks/>
        public byte negotiationProtocolOwner
        {
            get
            {
                return this.negotiationProtocolOwnerField;
            }
            set
            {
                this.negotiationProtocolOwnerField = value;
            }
        }

        /// <remarks/>
        public byte hardwareStatus
        {
            get
            {
                return this.hardwareStatusField;
            }
            set
            {
                this.hardwareStatusField = value;
            }
        }

        /// <remarks/>
        public byte portLegacy_powerDetectType
        {
            get
            {
                return this.portLegacy_powerDetectTypeField;
            }
            set
            {
                this.portLegacy_powerDetectTypeField = value;
            }
        }

        /// <remarks/>
        public byte powerManagementMode
        {
            get
            {
                return this.powerManagementModeField;
            }
            set
            {
                this.powerManagementModeField = value;
            }
        }

        /// <remarks/>
        public byte portClassLimit
        {
            get
            {
                return this.portClassLimitField;
            }
            set
            {
                this.portClassLimitField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ResponseDataDeviceConfigurationPoEPSEUnitList
    {

        private ResponseDataDeviceConfigurationPoEPSEUnitListUnitEntry unitEntryField;

        private string typeField;

        /// <remarks/>
        public ResponseDataDeviceConfigurationPoEPSEUnitListUnitEntry UnitEntry
        {
            get
            {
                return this.unitEntryField;
            }
            set
            {
                this.unitEntryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ResponseDataDeviceConfigurationPoEPSEUnitListUnitEntry
    {

        private byte unitIDField;

        private byte operStatusField;

        private byte nominalPowerField;

        private byte consumptionPowerField;

        private byte usageThresholdField;

        private byte trapsEnableField;

        private byte hWTypeField;

        private string sWversionField;

        private byte activePowerBankField;

        private string powerBankBudget0Field;

        /// <remarks/>
        public byte unitID
        {
            get
            {
                return this.unitIDField;
            }
            set
            {
                this.unitIDField = value;
            }
        }

        /// <remarks/>
        public byte operStatus
        {
            get
            {
                return this.operStatusField;
            }
            set
            {
                this.operStatusField = value;
            }
        }

        /// <remarks/>
        public byte nominalPower
        {
            get
            {
                return this.nominalPowerField;
            }
            set
            {
                this.nominalPowerField = value;
            }
        }

        /// <remarks/>
        public byte consumptionPower
        {
            get
            {
                return this.consumptionPowerField;
            }
            set
            {
                this.consumptionPowerField = value;
            }
        }

        /// <remarks/>
        public byte usageThreshold
        {
            get
            {
                return this.usageThresholdField;
            }
            set
            {
                this.usageThresholdField = value;
            }
        }

        /// <remarks/>
        public byte trapsEnable
        {
            get
            {
                return this.trapsEnableField;
            }
            set
            {
                this.trapsEnableField = value;
            }
        }

        /// <remarks/>
        public byte HWType
        {
            get
            {
                return this.hWTypeField;
            }
            set
            {
                this.hWTypeField = value;
            }
        }

        /// <remarks/>
        public string SWversion
        {
            get
            {
                return this.sWversionField;
            }
            set
            {
                this.sWversionField = value;
            }
        }

        /// <remarks/>
        public byte activePowerBank
        {
            get
            {
                return this.activePowerBankField;
            }
            set
            {
                this.activePowerBankField = value;
            }
        }

        /// <remarks/>
        public string powerBankBudget0
        {
            get
            {
                return this.powerBankBudget0Field;
            }
            set
            {
                this.powerBankBudget0Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ResponseDataDeviceConfigurationRMONStatistics
    {

        private ResponseDataDeviceConfigurationRMONStatisticsInterfaceStatisticsEntry[] interfaceStatisticsListField;

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("InterfaceStatisticsEntry", IsNullable = false)]
        public ResponseDataDeviceConfigurationRMONStatisticsInterfaceStatisticsEntry[] InterfaceStatisticsList
        {
            get
            {
                return this.interfaceStatisticsListField;
            }
            set
            {
                this.interfaceStatisticsListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ResponseDataDeviceConfigurationRMONStatisticsInterfaceStatisticsEntry
    {

        private string interfaceNameField;

        private byte interfaceTypeField;

        private uint interfaceIDField;

        private uint dropEventCountField;

        private uint receivePacketByteCountField;

        private uint receivePacketCountField;

        private uint receiveBroadcastPacketCountField;

        private uint receiveMulticastPacketCountField;

        private uint cRCAlignErrorCountField;

        private uint undersizePacketCountField;

        private uint oversizePacketCountField;

        private uint fragmentCountField;

        private uint jabberCountField;

        private uint collisionCountField;

        private uint frameOf64BytesCountField;

        private uint frameOf65To127BytesCountField;

        private uint frameOf128To255BytesCountField;

        private uint frameOf256To511BytesCountField;

        private uint frameOf512To1023BytesCountField;

        private uint frameOf1024To1518BytesCountField;

        /// <remarks/>
        public string interfaceName
        {
            get
            {
                return this.interfaceNameField;
            }
            set
            {
                this.interfaceNameField = value;
            }
        }

        /// <remarks/>
        public byte interfaceType
        {
            get
            {
                return this.interfaceTypeField;
            }
            set
            {
                this.interfaceTypeField = value;
            }
        }

        /// <remarks/>
        public uint interfaceID
        {
            get
            {
                return this.interfaceIDField;
            }
            set
            {
                this.interfaceIDField = value;
            }
        }

        /// <remarks/>
        public uint dropEventCount
        {
            get
            {
                return this.dropEventCountField;
            }
            set
            {
                this.dropEventCountField = value;
            }
        }

        /// <remarks/>
        public uint receivePacketByteCount
        {
            get
            {
                return this.receivePacketByteCountField;
            }
            set
            {
                this.receivePacketByteCountField = value;
            }
        }

        /// <remarks/>
        public uint receivePacketCount
        {
            get
            {
                return this.receivePacketCountField;
            }
            set
            {
                this.receivePacketCountField = value;
            }
        }

        /// <remarks/>
        public uint receiveBroadcastPacketCount
        {
            get
            {
                return this.receiveBroadcastPacketCountField;
            }
            set
            {
                this.receiveBroadcastPacketCountField = value;
            }
        }

        /// <remarks/>
        public uint receiveMulticastPacketCount
        {
            get
            {
                return this.receiveMulticastPacketCountField;
            }
            set
            {
                this.receiveMulticastPacketCountField = value;
            }
        }

        /// <remarks/>
        public uint CRCAlignErrorCount
        {
            get
            {
                return this.cRCAlignErrorCountField;
            }
            set
            {
                this.cRCAlignErrorCountField = value;
            }
        }

        /// <remarks/>
        public uint undersizePacketCount
        {
            get
            {
                return this.undersizePacketCountField;
            }
            set
            {
                this.undersizePacketCountField = value;
            }
        }

        /// <remarks/>
        public uint oversizePacketCount
        {
            get
            {
                return this.oversizePacketCountField;
            }
            set
            {
                this.oversizePacketCountField = value;
            }
        }

        /// <remarks/>
        public uint fragmentCount
        {
            get
            {
                return this.fragmentCountField;
            }
            set
            {
                this.fragmentCountField = value;
            }
        }

        /// <remarks/>
        public uint jabberCount
        {
            get
            {
                return this.jabberCountField;
            }
            set
            {
                this.jabberCountField = value;
            }
        }

        /// <remarks/>
        public uint collisionCount
        {
            get
            {
                return this.collisionCountField;
            }
            set
            {
                this.collisionCountField = value;
            }
        }

        /// <remarks/>
        public uint frameOf64BytesCount
        {
            get
            {
                return this.frameOf64BytesCountField;
            }
            set
            {
                this.frameOf64BytesCountField = value;
            }
        }

        /// <remarks/>
        public uint frameOf65To127BytesCount
        {
            get
            {
                return this.frameOf65To127BytesCountField;
            }
            set
            {
                this.frameOf65To127BytesCountField = value;
            }
        }

        /// <remarks/>
        public uint frameOf128To255BytesCount
        {
            get
            {
                return this.frameOf128To255BytesCountField;
            }
            set
            {
                this.frameOf128To255BytesCountField = value;
            }
        }

        /// <remarks/>
        public uint frameOf256To511BytesCount
        {
            get
            {
                return this.frameOf256To511BytesCountField;
            }
            set
            {
                this.frameOf256To511BytesCountField = value;
            }
        }

        /// <remarks/>
        public uint frameOf512To1023BytesCount
        {
            get
            {
                return this.frameOf512To1023BytesCountField;
            }
            set
            {
                this.frameOf512To1023BytesCountField = value;
            }
        }

        /// <remarks/>
        public uint frameOf1024To1518BytesCount
        {
            get
            {
                return this.frameOf1024To1518BytesCountField;
            }
            set
            {
                this.frameOf1024To1518BytesCountField = value;
            }
        }
    }
}

#pragma warning restore IDE1006 // Naming Styles
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
