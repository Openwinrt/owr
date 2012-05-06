namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Version(0x6020000), ExclusiveTo(typeof(GradientBrush)), Windows.Foundation.Metadata.Guid(0xed4779ca, 0x45bd, 0x4131, 0xb6, 0x25, 190, 0x86, 0xe0, 0x7c, 0x61, 0x12)]
    internal interface IGradientBrushFactory
    {
        GradientBrush CreateInstance([In] object outer, out object inner);
    }
}

