namespace Windows.UI.Xaml.Media.Imaging
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Composable(typeof(ISurfaceImageSourceFactory), CompositionType.Public, 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both), WebHostHidden, Version(0x6020000)]
    public class SurfaceImageSource : BitmapSource, ISurfaceImageSource
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public SurfaceImageSource([In] int pixelWidth, [In] int pixelHeight);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public SurfaceImageSource([In] int pixelWidth, [In] int pixelHeight, [In] bool isOpaque);
    }
}

