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

    [Version(0x6020000), Activatable(0x6020000), Threading(ThreadingModel.Both), WebHostHidden, MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class ManipulationDeltaRoutedEventArgs : RoutedEventArgs, IManipulationDeltaRoutedEventArgs
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ManipulationDeltaRoutedEventArgs();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Complete();

        public UIElement Container { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ManipulationDelta Cumulative { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ManipulationDelta Delta { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Handled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool IsInertial { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Devices.Input.PointerDeviceType PointerDeviceType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Point Position { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ManipulationVelocities Velocities { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public UIElement Windows.UI.Xaml.Input.IManipulationDeltaRoutedEventArgs.Container { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ManipulationDelta Windows.UI.Xaml.Input.IManipulationDeltaRoutedEventArgs.Cumulative { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ManipulationDelta Windows.UI.Xaml.Input.IManipulationDeltaRoutedEventArgs.Delta { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Xaml.Input.IManipulationDeltaRoutedEventArgs.Handled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.UI.Xaml.Input.IManipulationDeltaRoutedEventArgs.IsInertial { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Devices.Input.PointerDeviceType Windows.UI.Xaml.Input.IManipulationDeltaRoutedEventArgs.PointerDeviceType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Point Windows.UI.Xaml.Input.IManipulationDeltaRoutedEventArgs.Position { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ManipulationVelocities Windows.UI.Xaml.Input.IManipulationDeltaRoutedEventArgs.Velocities { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

