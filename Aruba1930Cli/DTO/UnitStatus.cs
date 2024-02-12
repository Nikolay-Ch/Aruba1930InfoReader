using System;

namespace Aruba1930Cli.DTO
{
    public readonly record struct UnitStatus
    {
        public int TemperatureSensorValue { get; init; }

        public int TemperatureSensorStatus { get; init; }

        public TimeSpan SystemUpTime { get; init; }
    }
}
