namespace Windows.UI.Input
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Devices.Input;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class RightTappedEventArgs : IRightTappedEventArgs
    {
        public Windows.Devices.Input.PointerDeviceType PointerDeviceType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Point Position { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Devices.Input.PointerDeviceType Windows.UI.Input.IRightTappedEventArgs.PointerDeviceType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Point Windows.UI.Input.IRightTappedEventArgs.Position { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

