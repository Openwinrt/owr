namespace Windows.UI.Xaml.Media.Imaging
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Threading(ThreadingModel.Both), Version(0x6020000), Activatable(typeof(IVirtualSurfaceImageSourceFactory), 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class VirtualSurfaceImageSource : SurfaceImageSource, IVirtualSurfaceImageSource
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public VirtualSurfaceImageSource([In] int pixelWidth, [In] int pixelHeight);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public VirtualSurfaceImageSource([In] int pixelWidth, [In] int pixelHeight, [In] bool isOpaque);
    }
}

