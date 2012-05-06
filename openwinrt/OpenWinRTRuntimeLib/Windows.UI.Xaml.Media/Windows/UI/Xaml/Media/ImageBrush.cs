namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Activatable(0x6020000), Static(typeof(IImageBrushStatics), 0x6020000), WebHostHidden, Threading(ThreadingModel.Both), MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000)]
    public sealed class ImageBrush : TileBrush, IImageBrush
    {
        public event ExceptionRoutedEventHandler ImageFailed;

        public event RoutedEventHandler ImageOpened;

        public event ExceptionRoutedEventHandler Windows.UI.Xaml.Media.IImageBrush.ImageFailed;

        public event RoutedEventHandler Windows.UI.Xaml.Media.IImageBrush.ImageOpened;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ImageBrush();

        public Windows.UI.Xaml.Media.ImageSource ImageSource { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty ImageSourceProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Media.ImageSource Windows.UI.Xaml.Media.IImageBrush.ImageSource { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

