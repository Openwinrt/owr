namespace Windows.UI.Input
{
    using Windows.Devices.Input;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(CrossSlidingEventArgs)), Guid(0xe9374738, 0x6f88, 0x41d9, 0x87, 0x20, 120, 0xe0, 0x8e, 0x39, 0x83, 0x49)]
    internal interface ICrossSlidingEventArgs
    {
        Windows.UI.Input.CrossSlidingState CrossSlidingState { get; }

        Windows.Devices.Input.PointerDeviceType PointerDeviceType { get; }

        Point Position { get; }
    }
}

