namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(RectangleGeometry)), Windows.Foundation.Metadata.Guid(0xa25a1f58, 0xc575, 0x4196, 0x91, 0xcf, 0x9f, 0xdf, 0xb1, 4, 0x45, 0xc3), Version(0x6020000), WebHostHidden]
    internal interface IRectangleGeometry
    {
        Windows.Foundation.Rect Rect { get; [param: In] set; }
    }
}

