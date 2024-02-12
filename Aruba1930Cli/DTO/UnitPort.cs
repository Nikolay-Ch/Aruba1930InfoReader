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

    public enum PortLinkStatus
    {
        LinkUp = 1,
        LinkDown = 2
    }

    public readonly record struct UnitPort
    {
        public bool PoESupported { get; init; }
        public int InterfaceIndex { get; init; }
        public required string PortName { get; init; }
        public int? Column { get; init; }
        public PortTransportType TransportType { get; init; }
        public PortSpeed Speed { get; init; }
        public PortLinkStatus LinkStatus { get; init; }
        public bool AdminMode { get; init; }
    }
}
