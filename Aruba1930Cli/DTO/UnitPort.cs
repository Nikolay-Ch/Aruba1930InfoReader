namespace Aruba1930Cli.DTO
{
    public enum PortTransportType
    {
        Ethernet = 1,
        STP = 2
    }

    public enum PortSpeed
    {
        BaseT10 = 10,
        BaseT100 = 100,
        BaseT1000 = 1000
    }

    /// <summary>
    /// Indicates the link status of the port.
    /// The possible values are:
    /// Link up.
    /// Link down.
    /// Suspended — Automatically disabled by the system due to schedule configurations, or error conditions.
    /// For example, an interface may be disabled by the switch due to an error condition.
    /// See the error logs for more information.
    /// </summary>
    public enum PortLinkStatus
    {
        /// <summary>
        /// Link Up
        /// </summary>
        LinkUp = 1,

        /// <summary>
        /// Link Down
        /// </summary>
        LinkDown = 2
    }

    /// <summary>
    /// Show the operational and administrative status of each port.
    /// </summary>
    public readonly record struct UnitPort
    {
        public bool PoESupported { get; init; }
        public int InterfaceIndex { get; init; }
        public required string PortName { get; init; }
        public int? Column { get; init; }
        public PortTransportType TransportType { get; init; }
        public PortSpeed Speed { get; init; }

        /// <summary>
        /// Indicates the link status of the port.
        /// </summary>
        public PortLinkStatus LinkStatus { get; init; }

        /// <summary>
        /// The administrative mode of the interface.
        /// If a port or trunk is administratively disabled, it cannot forward traffic.
        /// The possible values are:
        /// true — Administratively enabled.
        /// false — Administratively disabled.
        /// </summary>
        public bool AdminMode { get; init; }
    }
}
