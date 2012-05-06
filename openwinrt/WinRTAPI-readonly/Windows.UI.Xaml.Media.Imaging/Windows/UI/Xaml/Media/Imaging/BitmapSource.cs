namespace Windows.UI.Xaml.Media.Imaging
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Media;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both), WebHostHidden, Version(0x6020000), Static(typeof(IBitmapSourceStatics), 0x6020000), Composable(typeof(IBitmapSourceFactory), CompositionType.Protected, 0x6020000)]
    public class BitmapSource : ImageSource, IBitmapSource
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected BitmapSource();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SetSource([In] IRandomAccessStream streamSource);

        public int PixelHeight { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty PixelHeightProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int PixelWidth { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty PixelWidthProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int Windows.UI.Xaml.Media.Imaging.IBitmapSource.PixelHeight { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int Windows.UI.Xaml.Media.Imaging.IBitmapSource.PixelWidth { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

