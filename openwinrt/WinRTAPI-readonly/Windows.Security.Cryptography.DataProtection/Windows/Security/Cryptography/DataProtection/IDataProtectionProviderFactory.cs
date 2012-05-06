namespace Windows.Security.Cryptography.DataProtection
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0xadf33dac, 0x4932, 0x4cdf, 0xac, 0x41, 0x72, 20, 0x33, 0x35, 20, 0xca), ExclusiveTo(typeof(DataProtectionProvider))]
    internal interface IDataProtectionProviderFactory
    {
        DataProtectionProvider CreateOverloadExplicit([In] string protectionDescriptor);
    }
}

