namespace Windows.UI.Xaml.Shapes
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Media;

    [WebHostHidden, ExclusiveTo(typeof(Shape)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0x786f2b75, 0x9aa0, 0x454d, 0xae, 6, 0xa2, 70, 110, 0x37, 200, 50)]
    internal interface IShape
    {
        Brush Fill { get; [param: In] set; }

        Transform GeometryTransform { get; }

        Windows.UI.Xaml.Media.Stretch Stretch { get; [param: In] set; }

        Brush Stroke { get; [param: In] set; }

        DoubleCollection StrokeDashArray { get; [param: In] set; }

        PenLineCap StrokeDashCap { get; [param: In] set; }

        double StrokeDashOffset { get; [param: In] set; }

        PenLineCap StrokeEndLineCap { get; [param: In] set; }

        PenLineJoin StrokeLineJoin { get; [param: In] set; }

        double StrokeMiterLimit { get; [param: In] set; }

        PenLineCap StrokeStartLineCap { get; [param: In] set; }

        double StrokeThickness { get; [param: In] set; }
    }
}

