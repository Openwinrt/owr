namespace Windows.Storage
{
    using Windows.Foundation.Metadata;

    [Guid(0x5612147b, 0xe843, 0x45e3, 0x94, 0xd8, 6, 0x16, 0x9e, 60, 0x8e, 0x17), Version(0x6020000), ExclusiveTo(typeof(ApplicationData))]
    internal interface IApplicationDataStatics
    {
        ApplicationData Current { get; }
    }
}

