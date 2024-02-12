namespace Aruba1930Cli.DTO
{
    /// <summary>
    /// The current status of the switch PoE functionality.
    /// Delivering — At least one port on the switch is delivering power to a connected switch, and no port is in Fault state.
    /// Idle — The PoE functionality is operational but no ports are delivering power, and no ports have errors.
    /// Faulty— one or more ports is not functioning due to a hardware fault or is in the hardware fault-recovery state.
    /// Not Functional — PoE is not functional on switch due to a hardware failure.
    /// Error — One or more ports is in PoE fault state. this does not include hardware-related fault states.
    /// </summary>
    public enum UnitPoEStatus
    {
        /// <summary>
        /// At least one port on the switch is delivering power to a connected switch, and no port is in Fault state.
        /// </summary>
        Delivering = 1,

        /// <summary>
        /// The PoE functionality is operational but no ports are delivering power, and no ports have errors.
        /// </summary>
        //Idle = ?, uncomment this line, when you get this status to setup status number

        /// <summary>
        /// One or more ports is not functioning due to a hardware fault or is in the hardware fault-recovery state.
        /// </summary>
        //Faulty = ?, uncomment this line, when you get this status to setup status number

        /// <summary>
        /// PoE is not functional on switch due to a hardware failure.
        /// </summary>
        //NotFunctional = ?, uncomment this line, when you get this status to setup status number

        /// <summary>
        /// One or more ports is in PoE fault state. this does not include hardware-related fault states.
        /// </summary>
        //Error = ?, uncomment this line, when you get this status to setup status number
    }

    /// <summary>
    /// The Status tile displays PoE global information: the total power, actual power consumption, and PoE status.
    /// </summary>
    public readonly record struct UnitStatusPoE
    {
        /// <summary>
        /// The current status of the switch PoE functionality.
        /// </summary>
        public int PoEStatus { get; init; }

        /// <summary>
        /// The total power in watts that can be provided by the switch.
        /// </summary>
        public int PowerTotal { get; init; }

        /// <summary>
        /// The amount of power in watts currently being consumed by connected PoE devices (PD).
        /// </summary>
        public int PowerConsumption { get; init; }
    }
}
