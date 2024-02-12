namespace Aruba1930Cli.Dto
{
    public enum PortPoEStatus
    {
        Searching = 2,
        Delivering = 3
    }

    public enum PortPowerPriority
    {
        Critical = 1,
        High = 2,
        Low = 3
    }

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
        public uint Overloads { get; init; }
        public uint Denials { get; init; }
        public uint Absences { get; init; }
        public uint InvalidSignatures { get; init; }
        public uint Shorts { get; init; }
    }

    public readonly record struct UnitPortPoE
    {
        public required string PortName { get; init; }
        public int InterfaceIndex { get; init; }
        public bool AdminEnable { get; init; }
        public PortPoEStatus PoEStatus { get; init; }
        public PortPowerPriority PowerPriority { get; init; }
        public PortPowerClass PowerClass { get; init; }
        public PortEventCounters EventCounters { get; init; }
        public decimal OutputVoltage { get; init; }
        public decimal OutputCurrrent { get; init; }
        public decimal PowerLimit { get; init; }
        public decimal MaxPowerAllocation { get; init; }
        public decimal NegotiatedPower { get; init; }
        public decimal OutputPower { get; init; }
    }
}