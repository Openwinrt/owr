namespace Windows.UI.Xaml.Input
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Devices.Input;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Version(0x6020000), Activatable(0x6020000), Threading(ThreadingModel.Both), WebHostHidden, MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class DoubleTappedRoutedEventArgs : RoutedEventArgs, IDoubleTappedRoutedEventArgs
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public DoubleTappedRoutedEventArgs();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Point GetPosition([In] UIElement relativeTo);

        public bool Handled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.Devices.Input.PointerDeviceType PointerDeviceType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Xaml.Input.IDoubleTappedRoutedEventArgs.Handled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.Devices.Input.PointerDeviceType Windows.UI.Xaml.Input.IDoubleTappedRoutedEventArgs.PointerDeviceType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

