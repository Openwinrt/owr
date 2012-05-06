namespace Windows.Networking.NetworkOperators
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Activatable(0x6020000), Static(typeof(IProvisioningAgentStaticMethods), 0x6020000), Version(0x6020000), DualApiPartition(version=0x6020000), Threading(ThreadingModel.Both)]
    public sealed class ProvisioningAgent : IProvisioningAgent
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ProvisioningAgent();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static ProvisioningAgent CreateFromNetworkAccountId([In] string networkAccountId);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ProvisionedProfile GetProvisionedProfile([In] ProfileMediaType mediaType, [In] string profileName);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperation<ProvisionFromXmlDocumentResults> ProvisionFromXmlDocumentAsync([In] string provisioningXmlDocument);
    }
}

