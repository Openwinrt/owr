namespace Windows.UI
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [StructLayout(LayoutKind.Sequential), Version(0x6020000)]
    public struct Color
    {
        public byte A;
        public byte R;
        public byte G;
        public byte B;
    }
}

