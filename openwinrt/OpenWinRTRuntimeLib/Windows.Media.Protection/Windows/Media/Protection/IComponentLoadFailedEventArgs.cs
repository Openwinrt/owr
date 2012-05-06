namespace Windows.Media.Protection
{
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(ComponentLoadFailedEventArgs)), Guid(0x95972e93, 0x7746, 0x417e, 0x84, 0x95, 240, 0x31, 0xbb, 0xc5, 0x86, 0x2c)]
    internal interface IComponentLoadFailedEventArgs
    {
        MediaProtectionServiceCompletion Completion { get; }

        RevocationAndRenewalInformation Information { get; }
    }
}

