namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xae0861c, 0x1e7a, 0x4fed, 0x98, 0x57, 0xea, 140, 170, 0x79, 0x84, 0x90), ExclusiveTo(typeof(LinearGradientBrush)), Version(0x6020000), WebHostHidden]
    internal interface ILinearGradientBrushFactory
    {
        LinearGradientBrush CreateInstanceWithGradientStopCollectionAndAngle([In] GradientStopCollection gradientStopCollection, [In] double angle);
    }
}

