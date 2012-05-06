namespace Windows.Devices.Input
{
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0x484a9045, 0x6d70, 0x49db, 0x8e, 0x68, 70, 0xff, 0xbd, 0x17, 0xd3, 0x8d), ExclusiveTo(typeof(MouseDevice)), WebHostHidden]
    internal interface IMouseDeviceStatics
    {
        MouseDevice GetForCurrentView();
    }
}

