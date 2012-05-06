namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [StructLayout(LayoutKind.Sequential), Version(0x6020000), WebHostHidden]
    public struct Thickness
    {
        public double Left;
        public double Top;
        public double Right;
        public double Bottom;
    }
}

