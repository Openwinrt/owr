namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [WebHostHidden, ExclusiveTo(typeof(GradientBrush)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0x2166e69f, 0x935a, 0x4191, 0x8e, 60, 0x1c, 0x8d, 0xfd, 0xfc, 220, 120)]
    internal interface IGradientBrush
    {
        Windows.UI.Xaml.Media.ColorInterpolationMode ColorInterpolationMode { get; [param: In] set; }

        GradientStopCollection GradientStops { get; [param: In] set; }

        BrushMappingMode MappingMode { get; [param: In] set; }

        GradientSpreadMethod SpreadMethod { get; [param: In] set; }
    }
}

