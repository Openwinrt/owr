namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(CompositeTransform)), Windows.Foundation.Metadata.Guid(0xc8a4385b, 0xf24a, 0x4701, 0xa2, 0x65, 0xa7, 0x88, 70, 0xf1, 0x42, 0xb9), Version(0x6020000), WebHostHidden]
    internal interface ICompositeTransform
    {
        double CenterX { get; [param: In] set; }

        double CenterY { get; [param: In] set; }

        double Rotation { get; [param: In] set; }

        double ScaleX { get; [param: In] set; }

        double ScaleY { get; [param: In] set; }

        double SkewX { get; [param: In] set; }

        double SkewY { get; [param: In] set; }

        double TranslateX { get; [param: In] set; }

        double TranslateY { get; [param: In] set; }
    }
}

