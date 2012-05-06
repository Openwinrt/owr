namespace Windows.Devices.Input
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Version(0x6020000), ExclusiveTo(typeof(MouseDevice)), Windows.Foundation.Metadata.Guid(0x88edf458, 0xf2c8, 0x49f4, 190, 0x1f, 0xc2, 0x56, 0xb3, 0x88, 0xbc, 0x11)]
    internal interface IMouseDevice
    {
        event TypedEventHandler<MouseDevice, MouseEventArgs> MouseMoved;
    }
}

