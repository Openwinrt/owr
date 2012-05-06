namespace Windows.Networking.Sockets
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [StructLayout(LayoutKind.Sequential), Version(0x6020000)]
    public struct RoundTripTimeStatistics
    {
        public uint Variance;
        public uint Max;
        public uint Min;
        public uint Sum;
    }
}

