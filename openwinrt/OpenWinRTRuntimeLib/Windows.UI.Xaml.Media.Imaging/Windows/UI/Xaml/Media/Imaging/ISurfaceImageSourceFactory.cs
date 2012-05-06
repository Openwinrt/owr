namespace Windows.UI.Xaml.Media.Imaging
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Windows.Foundation.Metadata.Guid(0x3ab2212a, 0xef65, 0x4a5f, 0xbf, 0xac, 0x73, 0x99, 0x3e, 140, 0x12, 0xc9), Version(0x6020000), ExclusiveTo(typeof(SurfaceImageSource))]
    internal interface ISurfaceImageSourceFactory
    {
        SurfaceImageSource CreateInstanceWithDimensions([In] int pixelWidth, [In] int pixelHeight, [In] object outer, out object inner);
        SurfaceImageSource CreateInstanceWithDimensionsAndOpacity([In] int pixelWidth, [In] int pixelHeight, [In] bool isOpaque, [In] object outer, out object inner);
    }
}

