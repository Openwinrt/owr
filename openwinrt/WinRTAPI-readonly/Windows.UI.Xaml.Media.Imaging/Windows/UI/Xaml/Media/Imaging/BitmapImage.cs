namespace Windows.UI.Xaml.Media.Imaging
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000), Activatable(typeof(IBitmapImageFactory), 0x6020000), Static(typeof(IBitmapImageStatics), 0x6020000), Threading(ThreadingModel.Both), WebHostHidden, Activatable(0x6020000)]
    public sealed class BitmapImage : BitmapSource, IBitmapImage
    {
        public event DownloadProgressEventHandler DownloadProgress;

        public event ExceptionRoutedEventHandler ImageFailed;

        public event RoutedEventHandler ImageOpened;

        public event DownloadProgressEventHandler Windows.UI.Xaml.Media.Imaging.IBitmapImage.DownloadProgress;

        public event ExceptionRoutedEventHandler Windows.UI.Xaml.Media.Imaging.IBitmapImage.ImageFailed;

        public event RoutedEventHandler Windows.UI.Xaml.Media.Imaging.IBitmapImage.ImageOpened;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public BitmapImage();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public BitmapImage([In] Uri uriSource);

        public BitmapCreateOptions CreateOptions { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty CreateOptionsProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int DecodePixelHeight { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty DecodePixelHeightProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int DecodePixelWidth { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty DecodePixelWidthProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Uri UriSource { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty UriSourceProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public BitmapCreateOptions Windows.UI.Xaml.Media.Imaging.IBitmapImage.CreateOptions { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public int Windows.UI.Xaml.Media.Imaging.IBitmapImage.DecodePixelHeight { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public int Windows.UI.Xaml.Media.Imaging.IBitmapImage.DecodePixelWidth { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Uri Windows.UI.Xaml.Media.Imaging.IBitmapImage.UriSource { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

