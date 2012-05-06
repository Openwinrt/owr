namespace Windows.Networking.NetworkOperators
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(ProvisioningAgent)), Windows.Foundation.Metadata.Guid(0x217700e0, 0x8201, 0x11df, 0xad, 0xb9, 0xf4, 0xce, 70, 0x2d, 0x91, 0x37)]
    internal interface IProvisioningAgent
    {
        ProvisionedProfile GetProvisionedProfile([In] ProfileMediaType mediaType, [In] string profileName);
        IAsyncOperation<ProvisionFromXmlDocumentResults> ProvisionFromXmlDocumentAsync([In] string provisioningXmlDocument);
    }
}

