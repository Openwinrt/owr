namespace Windows.Foundation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [StructLayout(LayoutKind.Sequential), Version(0x6020000)]
    public struct Rect
    {
        public float X;
        public float Y;
        public float Width;
        public float Height;
    }
}

