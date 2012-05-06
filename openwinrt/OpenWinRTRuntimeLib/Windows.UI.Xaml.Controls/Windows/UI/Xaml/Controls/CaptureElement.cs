namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.Media.Capture;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Media;

    [Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Static(typeof(ICaptureElementStatics), 0x6020000), Activatable(0x6020000), Threading(ThreadingModel.Both), WebHostHidden]
    public sealed class CaptureElement : FrameworkElement, ICaptureElement
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public CaptureElement();

        public MediaCapture Source { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty SourceProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Media.Stretch Stretch { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty StretchProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public MediaCapture Windows.UI.Xaml.Controls.ICaptureElement.Source { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.UI.Xaml.Media.Stretch Windows.UI.Xaml.Controls.ICaptureElement.Stretch { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

