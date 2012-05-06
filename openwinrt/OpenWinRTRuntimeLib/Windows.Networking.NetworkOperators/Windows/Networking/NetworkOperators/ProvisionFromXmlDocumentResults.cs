namespace Windows.Networking.NetworkOperators
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), DualApiPartition(version=0x6020000)]
    public sealed class ProvisionFromXmlDocumentResults : IProvisionFromXmlDocumentResults
    {
        public bool AllElementsProvisioned { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string ProvisionResultsXml { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.Networking.NetworkOperators.IProvisionFromXmlDocumentResults.AllElementsProvisioned { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Networking.NetworkOperators.IProvisionFromXmlDocumentResults.ProvisionResultsXml { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

