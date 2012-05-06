namespace Windows.UI.Input
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Devices.Input;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class CrossSlidingEventArgs : ICrossSlidingEventArgs
    {
        public Windows.UI.Input.CrossSlidingState CrossSlidingState { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Devices.Input.PointerDeviceType PointerDeviceType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Point Position { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Input.CrossSlidingState Windows.UI.Input.ICrossSlidingEventArgs.CrossSlidingState { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Devices.Input.PointerDeviceType Windows.UI.Input.ICrossSlidingEventArgs.PointerDeviceType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Point Windows.UI.Input.ICrossSlidingEventArgs.Position { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

