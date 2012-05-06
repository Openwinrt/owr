namespace Windows.UI.Xaml.Controls.Primitives
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Threading(ThreadingModel.Both), MarshalingBehavior(MarshalingType.FreeThreaded), Static(typeof(ILayoutInformationStatics), 0x6020000), WebHostHidden, Version(0x6020000)]
    public sealed class LayoutInformation : ILayoutInformation
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static UIElement GetLayoutExceptionElement([In] object dispatcher);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static Rect GetLayoutSlot([In] FrameworkElement element);
    }
}

