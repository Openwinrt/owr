namespace Windows.Networking.Sockets
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [StructLayout(LayoutKind.Sequential), Version(0x6020000)]
    public struct BandwidthStatistics
    {
        public ulong OutboundBitsPerSecond;
        public ulong InboundBitsPerSecond;
        public ulong OutboundInstability;
        public ulong InboundInstability;
        public bool OutboundBandwidthPeaked;
        public bool InboundBandwidthPeaked;
    }
}

