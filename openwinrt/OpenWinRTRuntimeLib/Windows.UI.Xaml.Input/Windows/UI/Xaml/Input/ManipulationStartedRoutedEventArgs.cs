namespace Windows.UI.Xaml.Input
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Devices.Input;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Input;
    using Windows.UI.Xaml;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both), WebHostHidden, Composable(typeof(IManipulationStartedRoutedEventArgsFactory), CompositionType.Public, 0x6020000), Version(0x6020000)]
    public class ManipulationStartedRoutedEventArgs : RoutedEventArgs, IManipulationStartedRoutedEventArgs
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ManipulationStartedRoutedEventArgs();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Complete();

        public UIElement Container { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ManipulationDelta Cumulative { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Handled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.Devices.Input.PointerDeviceType PointerDeviceType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Point Position { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public UIElement Windows.UI.Xaml.Input.IManipulationStartedRoutedEventArgs.Container { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ManipulationDelta Windows.UI.Xaml.Input.IManipulationStartedRoutedEventArgs.Cumulative { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Xaml.Input.IManipulationStartedRoutedEventArgs.Handled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.Devices.Input.PointerDeviceType Windows.UI.Xaml.Input.IManipulationStartedRoutedEventArgs.PointerDeviceType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Point Windows.UI.Xaml.Input.IManipulationStartedRoutedEventArgs.Position { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

