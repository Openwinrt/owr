namespace Windows.UI.Input
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Devices.Input;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class ManipulationStartedEventArgs : IManipulationStartedEventArgs
    {
        public ManipulationDelta Cumulative { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Devices.Input.PointerDeviceType PointerDeviceType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Point Position { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ManipulationDelta Windows.UI.Input.IManipulationStartedEventArgs.Cumulative { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Devices.Input.PointerDeviceType Windows.UI.Input.IManipulationStartedEventArgs.PointerDeviceType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Point Windows.UI.Input.IManipulationStartedEventArgs.Position { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

