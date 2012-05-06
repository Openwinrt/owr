namespace Windows.UI.Xaml.Input
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.System;
    using Windows.UI.Input;
    using Windows.UI.Xaml;

    [Threading(ThreadingModel.Both), MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000), WebHostHidden]
    public sealed class PointerEventArgs : RoutedEventArgs, IPointerEventArgs
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public PointerPoint GetCurrentPoint([In] UIElement relativeTo);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IVector<PointerPoint> GetIntermediatePoints([In] UIElement relativeTo);

        public bool Handled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public VirtualKeyModifiers KeyModifiers { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Input.Pointer Pointer { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Xaml.Input.IPointerEventArgs.Handled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public VirtualKeyModifiers Windows.UI.Xaml.Input.IPointerEventArgs.KeyModifiers { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Input.Pointer Windows.UI.Xaml.Input.IPointerEventArgs.Pointer { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

