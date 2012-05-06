namespace Windows.UI.Input
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Devices.Input;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class ManipulationUpdatedEventArgs : IManipulationUpdatedEventArgs
    {
        public ManipulationDelta Cumulative { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ManipulationDelta Delta { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Devices.Input.PointerDeviceType PointerDeviceType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Point Position { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ManipulationVelocities Velocities { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ManipulationDelta Windows.UI.Input.IManipulationUpdatedEventArgs.Cumulative { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ManipulationDelta Windows.UI.Input.IManipulationUpdatedEventArgs.Delta { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Devices.Input.PointerDeviceType Windows.UI.Input.IManipulationUpdatedEventArgs.PointerDeviceType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Point Windows.UI.Input.IManipulationUpdatedEventArgs.Position { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ManipulationVelocities Windows.UI.Input.IManipulationUpdatedEventArgs.Velocities { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

