namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Media.PlayTo;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Media;

    [Activatable(0x6020000), Version(0x6020000), Threading(ThreadingModel.Both), WebHostHidden, Static(typeof(IImageStatics), 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class Image : FrameworkElement, IImage
    {
        public event ExceptionRoutedEventHandler ImageFailed;

        public event RoutedEventHandler ImageOpened;

        public event ExceptionRoutedEventHandler Windows.UI.Xaml.Controls.IImage.ImageFailed;

        public event RoutedEventHandler Windows.UI.Xaml.Controls.IImage.ImageOpened;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Image();

        public Thickness NineGrid { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty NineGridProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Media.PlayTo.PlayToSource PlayToSource { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty PlayToSourceProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ImageSource Source { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty SourceProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Media.Stretch Stretch { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty StretchProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Thickness Windows.UI.Xaml.Controls.IImage.NineGrid { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.Media.PlayTo.PlayToSource Windows.UI.Xaml.Controls.IImage.PlayToSource { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ImageSource Windows.UI.Xaml.Controls.IImage.Source { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.UI.Xaml.Media.Stretch Windows.UI.Xaml.Controls.IImage.Stretch { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

