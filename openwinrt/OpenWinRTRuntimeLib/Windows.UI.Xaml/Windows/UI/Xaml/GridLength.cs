namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [StructLayout(LayoutKind.Sequential), Version(0x6020000), WebHostHidden]
    public struct GridLength
    {
        public double Value;
        public Windows.UI.Xaml.GridUnitType GridUnitType;
    }
}

