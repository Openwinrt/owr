namespace Windows.Security.Cryptography.Certificates
{
    using System;
    using Windows.Foundation.Metadata;

    [Guid(0xaf186ae0, 0x5529, 0x4602, 0xbd, 0x94, 10, 0xab, 0x91, 0x95, 0x7b, 0x5c), ExclusiveTo(typeof(KeyStorageProviderNames)), Version(0x8000000)]
    internal interface IKeyStorageProviderNamesStatics
    {
        string PlatformKeyStorageProvider { get; }

        string SmartcardKeyStorageProvider { get; }

        string SoftwareKeyStorageProvider { get; }
    }
}

