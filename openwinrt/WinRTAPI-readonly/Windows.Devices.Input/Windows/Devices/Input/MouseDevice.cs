namespace Windows.Devices.Input
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Static(typeof(IMouseDeviceStatics), 0x6020000), Version(0x6020000), WebHostHidden]
    public sealed class MouseDevice : IMouseDevice
    {
        public event TypedEventHandler<MouseDevice, MouseEventArgs> MouseMoved;

        public event TypedEventHandler<MouseDevice, MouseEventArgs> Windows.Devices.Input.IMouseDevice.MouseMoved;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static MouseDevice GetForCurrentView();
    }
}

