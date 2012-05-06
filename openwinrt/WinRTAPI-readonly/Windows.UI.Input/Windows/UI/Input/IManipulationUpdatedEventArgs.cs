namespace Windows.UI.Input
{
    using Windows.Devices.Input;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Guid(0xcb354ce5, 0xabb8, 0x4f9f, 0xb3, 0xce, 0x81, 0x81, 170, 0x61, 0xad, 130), Version(0x6020000), ExclusiveTo(typeof(ManipulationUpdatedEventArgs))]
    internal interface IManipulationUpdatedEventArgs
    {
        ManipulationDelta Cumulative { get; }

        ManipulationDelta Delta { get; }

        Windows.Devices.Input.PointerDeviceType PointerDeviceType { get; }

        Point Position { get; }

        ManipulationVelocities Velocities { get; }
    }
}

