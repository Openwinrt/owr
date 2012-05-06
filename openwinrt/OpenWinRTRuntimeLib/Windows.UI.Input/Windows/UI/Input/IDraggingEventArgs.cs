namespace Windows.UI.Input
{
    using Windows.Devices.Input;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Guid(0x1c905384, 0x83c, 0x4bd3, 0xb5, 0x59, 0x17, 0x9c, 0xdd, 0xeb, 0x33, 0xec), Version(0x6020000), ExclusiveTo(typeof(DraggingEventArgs))]
    internal interface IDraggingEventArgs
    {
        Windows.UI.Input.DraggingState DraggingState { get; }

        Windows.Devices.Input.PointerDeviceType PointerDeviceType { get; }

        Point Position { get; }
    }
}

