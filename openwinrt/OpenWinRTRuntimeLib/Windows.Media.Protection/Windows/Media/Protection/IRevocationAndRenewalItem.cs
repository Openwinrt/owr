namespace Windows.Media.Protection
{
    using System;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(RevocationAndRenewalItem)), Guid(0x3099c20c, 0x3cf0, 0x49ea, 0x90, 0x2d, 0xca, 0xf3, 0x2d, 0x2d, 0xde, 0x2c), Version(0x6020000)]
    internal interface IRevocationAndRenewalItem
    {
        string HeaderHash { get; }

        string Name { get; }

        string PublicKeyHash { get; }

        RevocationAndRenewalReasons Reasons { get; }

        string RenewalId { get; }
    }
}

