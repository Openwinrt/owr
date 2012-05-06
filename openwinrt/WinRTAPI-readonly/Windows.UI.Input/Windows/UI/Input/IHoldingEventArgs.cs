namespace Windows.UI.Input
{
    using Windows.Devices.Input;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Guid(0x2bf755c5, 0xe799, 0x41b4, 0xbb, 0x40, 0x24, 0x2f, 0x40, 0x95, 0x9b, 0x71), Version(0x6020000), ExclusiveTo(typeof(HoldingEventArgs))]
    internal interface IHoldingEventArgs
    {
        Windows.UI.Input.HoldingState HoldingState { get; }

        Windows.Devices.Input.PointerDeviceType PointerDeviceType { get; }

        Point Position { get; }
    }
}

