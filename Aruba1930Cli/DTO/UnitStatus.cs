using System;

namespace Aruba1930Cli.DTO
{
    public class UnitStatus
    {
        public int TemperatureSensorValue { get; init; }

        public int TemperatureSensorStatus { get; init; }

        public TimeSpan SystemUpTime { get; init; }
    }
}
