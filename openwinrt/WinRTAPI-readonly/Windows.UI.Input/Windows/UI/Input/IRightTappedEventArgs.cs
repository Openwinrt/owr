namespace Windows.UI.Input
{
    using Windows.Devices.Input;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Guid(0x4cbf40bd, 0xaf7a, 0x4a36, 0x94, 0x76, 0xb1, 220, 0xe1, 0x41, 0x70, 0x9a), ExclusiveTo(typeof(RightTappedEventArgs)), Version(0x6020000)]
    internal interface IRightTappedEventArgs
    {
        Windows.Devices.Input.PointerDeviceType PointerDeviceType { get; }

        Point Position { get; }
    }
}

