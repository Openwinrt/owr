namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [StructLayout(LayoutKind.Sequential), Version(0x6020000), WebHostHidden]
    public struct CornerRadius
    {
        public double TopLeft;
        public double TopRight;
        public double BottomRight;
        public double BottomLeft;
    }
}

