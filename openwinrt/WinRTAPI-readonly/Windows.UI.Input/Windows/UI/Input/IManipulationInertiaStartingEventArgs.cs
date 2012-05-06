namespace Windows.UI.Input
{
    using Windows.Devices.Input;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(ManipulationInertiaStartingEventArgs)), Version(0x6020000), Guid(0xdd37a898, 0x26bf, 0x467a, 0x9c, 0xe5, 0xcc, 0xf3, 0xfb, 0x11, 0x37, 30)]
    internal interface IManipulationInertiaStartingEventArgs
    {
        ManipulationDelta Cumulative { get; }

        ManipulationDelta Delta { get; }

        Windows.Devices.Input.PointerDeviceType PointerDeviceType { get; }

        Point Position { get; }

        ManipulationVelocities Velocities { get; }
    }
}

