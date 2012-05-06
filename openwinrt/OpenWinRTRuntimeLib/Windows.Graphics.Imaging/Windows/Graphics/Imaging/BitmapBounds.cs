namespace Windows.Graphics.Imaging
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [StructLayout(LayoutKind.Sequential), Version(0x6020000)]
    public struct BitmapBounds
    {
        public uint X;
        public uint Y;
        public uint Width;
        public uint Height;
    }
}

