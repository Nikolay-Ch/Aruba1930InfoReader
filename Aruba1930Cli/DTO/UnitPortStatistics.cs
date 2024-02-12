namespace Aruba1930Cli.Dto
{
    public readonly record struct UnitPortStatistics
    {
        public required string PortName { get; init; }
        public uint InterfaceIndex { get; init; }
        public uint DropEventCount { get; init; }
        public uint ReceivePacketByteCount { get; init; }
        public uint ReceivePacketCount { get; init; }
        public uint ReceiveBroadcastPacketCount { get; init; }
        public uint ReceiveMulticastPacketCount { get; init; }
        public uint CRCAlignErrorCount { get; init; }
        public uint UndersizePacketCount { get; init; }
        public uint OversizePacketCount { get; init; }
        public uint FragmentCount { get; init; }
        public uint JabberCount { get; init; }
        public uint CollisionCount { get; init; }
        public uint FrameOf64BytesCount { get; init; }
        public uint FrameOf65To127BytesCount { get; init; }
        public uint FrameOf128To255BytesCount { get; init; }
        public uint FrameOf256To511BytesCount { get; init; }
        public uint FrameOf512To1023BytesCount { get; init; }
        public uint FrameOf1024To1518BytesCount { get; init; }
    }
}
