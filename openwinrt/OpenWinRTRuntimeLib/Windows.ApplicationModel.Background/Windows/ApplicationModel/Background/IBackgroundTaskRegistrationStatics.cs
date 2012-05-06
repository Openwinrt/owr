namespace Windows.ApplicationModel.Background
{
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(BackgroundTaskRegistration)), Version(0x6020000), Guid(0x4c542f69, 0xb000, 0x42ba, 160, 0x93, 0x6a, 0x56, 60, 0x65, 0xe3, 0xf8)]
    internal interface IBackgroundTaskRegistrationStatics
    {
        IMapView<Guid, IBackgroundTaskRegistration> AllTasks { get; }
    }
}

