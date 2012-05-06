namespace Windows.UI.Xaml.Media.Imaging
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x3ab2212a, 0xbfac, 0x11e0, 0x8a, 0x92, 0x69, 0xe4, 0x47, 0x24, 1, 0x9b), Version(0x6020000), WebHostHidden, ExclusiveTo(typeof(VirtualSurfaceImageSource))]
    internal interface IVirtualSurfaceImageSourceFactory
    {
        VirtualSurfaceImageSource CreateInstanceWithDimensions([In] int pixelWidth, [In] int pixelHeight);
        VirtualSurfaceImageSource CreateInstanceWithDimensionsAndOpacity([In] int pixelWidth, [In] int pixelHeight, [In] bool isOpaque);
    }
}

