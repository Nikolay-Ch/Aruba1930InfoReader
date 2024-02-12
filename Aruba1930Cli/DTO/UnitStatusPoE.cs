namespace Aruba1930Cli.DTO
{
    public readonly record struct UnitStatusPoE
    {
        public int PoEStatus { get; init; }

        public int PowerTotal { get; init; }

        public int PowerConsumption { get; init; }
    }
}
