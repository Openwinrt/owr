namespace Windows.Graphics.Printing
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [StructLayout(LayoutKind.Sequential), Version(0x6020000)]
    public struct PrintPageDescription
    {
        public Size PageSize;
        public Rect ImageableRect;
        public uint DpiX;
        public uint DpiY;
    }
}

