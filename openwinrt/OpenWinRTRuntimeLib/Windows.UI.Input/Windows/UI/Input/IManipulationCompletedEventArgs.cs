namespace Windows.UI.Input
{
    using Windows.Devices.Input;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Guid(0xb34ab22b, 0xd19b, 0x46ff, 0x9f, 0x38, 0xde, 0xc7, 0x75, 0x4b, 0xb9, 0xe7), Version(0x6020000), ExclusiveTo(typeof(ManipulationCompletedEventArgs))]
    internal interface IManipulationCompletedEventArgs
    {
        ManipulationDelta Cumulative { get; }

        Windows.Devices.Input.PointerDeviceType PointerDeviceType { get; }

        Point Position { get; }

        ManipulationVelocities Velocities { get; }
    }
}

