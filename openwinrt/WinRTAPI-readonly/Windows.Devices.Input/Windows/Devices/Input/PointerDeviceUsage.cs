namespace Windows.Devices.Input
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [StructLayout(LayoutKind.Sequential), Version(0x6020000)]
    public struct PointerDeviceUsage
    {
        public uint UsagePage;
        public uint Usage;
        public int MinLogical;
        public int MaxLogical;
        public int MinPhysical;
        public int MaxPhysical;
        public uint Unit;
        public float PhysicalMultiplier;
    }
}

