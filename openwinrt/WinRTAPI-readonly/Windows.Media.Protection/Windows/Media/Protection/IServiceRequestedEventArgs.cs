namespace Windows.Media.Protection
{
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(ServiceRequestedEventArgs)), Version(0x6020000), Guid(0x34283baf, 0xabb4, 0x4fc1, 0xbd, 0x89, 0x93, 0xf1, 6, 0x57, 0x3a, 0x49)]
    internal interface IServiceRequestedEventArgs
    {
        MediaProtectionServiceCompletion Completion { get; }

        IMediaProtectionServiceRequest Request { get; }
    }
}

