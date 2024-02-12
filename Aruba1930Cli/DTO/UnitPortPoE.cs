namespace Aruba1930Cli.Dto
{
    /// <summary>
    /// The current status of the switch PoE functionality.
    /// </summary>
    public enum PortPoEStatus
    {
        /// <summary>
        /// The PSE is transitioning between states.
        /// </summary>
        Searching = 2,

        /// <summary>
        /// The PSE is delivering power.
        /// </summary>
        Delivering = 3,

        /// <summary>
        /// The PSE has experienced a fault condition.
        /// </summary>
        //Fault = ?, uncomment this line, when you get this status to setup status number

        /// <summary>
        /// The operational status of the PSE is disabled.
        /// </summary>
        //Disabled = ?, uncomment this line, when you get this status to setup status number

        /// <summary>
        /// The port is recovering from a previous condition of internal hardware fault.
        /// </summary>
        //Recovering = ?, uncomment this line, when you get this status to setup status number
    }

    /// <summary>
    /// The priority of the port when allocating available power.
    /// Power is delivered to the higher-priority ports when needed before providing it to the lower priority ports.
    /// Possible values are Critical, High and Low. Low is the lowest priority and the default for all ports.
    /// </summary>
    public enum PortPowerPriority
    {
        Critical = 1,
        High = 2,

        /// <summary>
        /// Low is the lowest priority and the default for all ports.
        /// </summary>
        Low = 3
    }

    /// <summary>
    /// The class limit of a  port can be set to class 3 or unlimited.
    /// By default, the power is not limited (ports can deliver up to class 4).
    /// </summary>
    public enum PortPowerClass
    {
        Unlimited = 0,
        Class0 = 1,
        Class1 = 2,
        Class2 = 3,
        Class3 = 4
    }

    public readonly record struct PortEventCounters
    {
        /// <summary>
        /// The number of power overload events detected on the port.
        /// </summary>
        public uint Overloads { get; init; }

        /// <summary>
        /// The number of times that the powered device was denied power.
        /// </summary>
        public uint Denials { get; init; }

        /// <summary>
        /// The number of times that power was stopped to the powered device, because the powered device was not detected.
        /// </summary>
        public uint Absences { get; init; }

        /// <summary>
        /// The number of that an invalid signature was received.
        /// Signatures are the means by which the powered device identifies itself to the PSE.
        /// Signatures are generated during powered device detection, classification, or maintenance.
        /// </summary>
        public uint InvalidSignatures { get; init; }


        public uint Shorts { get; init; }
    }

    /// <summary>
    /// You can use the PoE Port Configuration to view the port priority and other settings.
    /// </summary>
    public readonly record struct UnitPortPoE
    {
        public required string PortName { get; init; }

        /// <summary>
        /// The port number.
        /// </summary>
        public int InterfaceIndex { get; init; }

        /// <summary>
        /// Indicates whether PoE is administratively enabled or disabled on the port.
        /// This feature is enabled by default.
        /// </summary>
        public bool AdminEnable { get; init; }

        /// <summary>
        /// 
        /// </summary>
        public PortPoEStatus PoEStatus { get; init; }

        /// <summary>
        /// The priority of the port when allocating available power.
        /// Power is delivered to the higher-priority ports when needed before providing it to the lower priority ports.
        /// Possible values are Critical, High and Low. Low is the lowest priority and the default for all ports.
        /// </summary>
        public PortPowerPriority PowerPriority { get; init; }

        /// <summary>
        /// The class limit of a  port can be set to class 3 or unlimited.
        /// By default, the power is not limited (ports can deliver up to class 4).
        /// </summary>
        public PortPowerClass PowerClass { get; init; }

        /// <summary>
        /// Indicates the type of fault condition that exists on the port.
        /// Possible values are:
        /// None - the port is not in fault condition.
        /// Short - a Short fault condition exists on the port.
        /// Overload - a PoE Overload fault condition exists on the port.
        /// Underload - a PoE Underload fault condition exists on the port.
        /// Power Denied - Power on port is denied due to power over-subscription condition on the switch.
        /// Hardware Fault - a general Hardware fault occurred on the switch which prevents power on port.
        /// Internal HW Fault - a hardware fault occurred on the interface.
        /// Other - a fault of a type not specified above occurred on the port.
        /// NOTE: This field is relevant only if the status of the port is Fault.
        /// </summary>
        //public byte FaultStatus {get; init; }, uncomment this line, when you get this status to check constants

        public PortEventCounters EventCounters { get; init; }

        /// <summary>
        /// The voltage being applied to the connected switch.
        /// </summary>
        public decimal OutputVoltage { get; init; }

        /// <summary>
        /// The current in milliamps being drawn by the connected switch.
        /// </summary>
        public decimal OutputCurrrent { get; init; }

        public decimal PowerLimit { get; init; }

        public decimal MaxPowerAllocation { get; init; }

        /// <summary>
        /// Power in watts negotiated between the port and connected switch.
        /// </summary>
        public decimal NegotiatedPower { get; init; }

        /// <summary>
        /// Power in watts being drawn by the connected switch.
        /// </summary>
        public decimal OutputPower { get; init; }
    }
}