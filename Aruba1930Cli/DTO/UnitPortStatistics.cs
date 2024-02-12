namespace Aruba1930Cli.Dto
{
    /// <summary>
    /// The RMON (Ethernet) statistics are counts of packets, octets (or bytes),
    /// broadcasts, multicasts and collisions on the local segment,
    /// as well as the number of occurrences of dropped packets by the agent.
    /// </summary>
    public readonly record struct UnitPortStatistics
    {
        public required string PortName { get; init; }

        /// <summary>
        /// The interface identifier.
        /// </summary>
        public uint InterfaceIndex { get; init; }

        /// <summary>
        /// Total number of events in which packets were dropped by the interface due to lack of resources.
        /// Note that this number is not necessarily the number of packets dropped.
        /// It is the number of times this condition was detected.
        /// </summary>
        public uint DropEventCount { get; init; }

        /// <summary>
        /// Total number of octets of data (including those in bad packets) received on the interface (excluding framing bits but including FCS octets).
        /// </summary>
        public uint ReceivePacketByteCount { get; init; }

        /// <summary>
        /// Total number of packets (including bad packets, broadcast packets, and multicast packets) received.
        /// </summary>
        public uint ReceivePacketCount { get; init; }

        /// <summary>
        /// The number of Broadcast packets received on the interface during the sample time.
        /// </summary>
        public uint ReceiveBroadcastPacketCount { get; init; }

        /// <summary>
        /// The number of Multicast packets received on the interface during the sample time.
        /// </summary>
        public uint ReceiveMulticastPacketCount { get; init; }

        /// <summary>
        /// The number of packets with a CRC Align error received on the interface during the sample time.
        /// </summary>
        public uint CRCAlignErrorCount { get; init; }

        /// <summary>
        /// The number of Undersize packets received on the interface during the sample time.
        /// </summary>
        public uint UndersizePacketCount { get; init; }

        /// <summary>
        /// The number of Oversize packets received on the interface during the sample time.
        /// </summary>
        public uint OversizePacketCount { get; init; }

        /// <summary>
        /// The number of fragment type packets received on the interface during the sample time.
        /// </summary>
        public uint FragmentCount { get; init; }

        /// <summary>
        /// The number of Jabber type packets received on the interface during the sample time.
        /// </summary>
        public uint JabberCount { get; init; }

        /// <summary>
        /// The estimated number of collisions which occurred on the interface during the sample time.
        /// </summary>
        public uint CollisionCount { get; init; }

        /// <summary>
        /// Total number of packets (including bad packets) received that are 64 byte frames in length
        /// (excluding framing bits but including FCS byte frames).
        /// </summary>
        public uint FrameOf64BytesCount { get; init; }

        /// <summary>
        /// Total number of packets (including bad packets) received that are between 65 and 127 byte frames in length
        /// inclusive (excluding framing bits but including FCS byte frames)
        /// </summary>
        public uint FrameOf65To127BytesCount { get; init; }

        /// <summary>
        /// Total number of packets (including bad packets) received that are between 128 and 255 byte frames in length
        /// inclusive (excluding framing bits but including FCS byte frames).
        /// </summary>
        public uint FrameOf128To255BytesCount { get; init; }

        /// <summary>
        /// Total number of packets (including bad packets) received that are between 256 and 511 byte frames in length
        /// inclusive (excluding framing bits but including FCS byte frames).
        /// </summary>
        public uint FrameOf256To511BytesCount { get; init; }

        /// <summary>
        /// Total number of packets (including bad packets) received that were between 512 and 1023 byte frames in length
        /// inclusive (excluding framing bits but including FCS byte frames).
        /// </summary>
        public uint FrameOf512To1023BytesCount { get; init; }

        /// <summary>
        /// Total number of packets (including bad packets) received that were between 1024 byte frames and the maximum frame size in length
        /// inclusive (excluding framing bits but including FCS byte frames).
        /// </summary>
        public uint FrameOf1024To1518BytesCount { get; init; }
    }
}
