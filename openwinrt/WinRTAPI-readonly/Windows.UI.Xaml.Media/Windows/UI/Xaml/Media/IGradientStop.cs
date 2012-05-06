namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI;

    [Version(0x6020000), ExclusiveTo(typeof(GradientStop)), WebHostHidden, Windows.Foundation.Metadata.Guid(0x665f44fe, 0x2e59, 0x4c4a, 0xab, 0x53, 7, 0x6a, 0x10, 12, 0xcd, 0x81)]
    internal interface IGradientStop
    {
        Windows.UI.Color Color { get; [param: In] set; }

        double Offset { get; [param: In] set; }
    }
}

