namespace Windows.Devices.Input
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [StructLayout(LayoutKind.Sequential), WebHostHidden, Version(0x6020000)]
    public struct MouseDelta
    {
        public int X;
        public int Y;
    }
}

