namespace Windows.Networking.NetworkOperators
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [StructLayout(LayoutKind.Sequential), Version(0x6020000)]
    public struct ProfileUsage
    {
        public uint UsageInMegabytes;
        public Windows.Foundation.DateTime LastSyncTime;
    }
}

