namespace Windows.UI.Input
{
    using Windows.Devices.Input;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(ManipulationStartedEventArgs)), Guid(0xddec873e, 0xcfce, 0x4932, 140, 0x1d, 60, 0x3d, 1, 0x1a, 0x34, 0xc0)]
    internal interface IManipulationStartedEventArgs
    {
        ManipulationDelta Cumulative { get; }

        Windows.Devices.Input.PointerDeviceType PointerDeviceType { get; }

        Point Position { get; }
    }
}

