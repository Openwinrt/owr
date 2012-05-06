namespace Windows.Media.Protection
{
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0xf3a1937b, 0x2501, 0x439e, 0xa6, 0xe7, 0x6f, 0xc9, 0x5e, 0x17, 0x5f, 0xcf), ExclusiveTo(typeof(RevocationAndRenewalInformation))]
    internal interface IRevocationAndRenewalInformation
    {
        IVector<RevocationAndRenewalItem> Items { get; }
    }
}

