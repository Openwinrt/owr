namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [StructLayout(LayoutKind.Sequential), WebHostHidden, Version(0x6020000)]
    public struct Matrix
    {
        public double M11;
        public double M12;
        public double M21;
        public double M22;
        public double OffsetX;
        public double OffsetY;
    }
}

