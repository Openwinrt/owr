namespace Windows.Security.Cryptography.Core
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(MacAlgorithmProvider)), Windows.Foundation.Metadata.Guid(0xc9bdc147, 0xcc77, 0x4df0, 0x9e, 0x4e, 0xb9, 0x21, 0xe0, 0x80, 100, 0x4c), Version(0x6020000)]
    internal interface IMacAlgorithmProviderStatics
    {
        MacAlgorithmProvider OpenAlgorithm([In] string algorithm);
    }
}

