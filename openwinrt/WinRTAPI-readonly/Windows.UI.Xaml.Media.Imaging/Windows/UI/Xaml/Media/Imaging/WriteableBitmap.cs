namespace Windows.UI.Xaml.Media.Imaging
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [WebHostHidden, Version(0x6020000), Activatable(typeof(IWriteableBitmapFactory), 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both)]
    public sealed class WriteableBitmap : BitmapSource, IWriteableBitmap
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public WriteableBitmap([In] int pixelWidth, [In] int pixelHeight);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Invalidate();

        public IBuffer PixelBuffer { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IBuffer Windows.UI.Xaml.Media.Imaging.IWriteableBitmap.PixelBuffer { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

