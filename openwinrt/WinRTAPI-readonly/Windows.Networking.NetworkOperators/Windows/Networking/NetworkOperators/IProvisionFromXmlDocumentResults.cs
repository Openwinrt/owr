namespace Windows.Networking.NetworkOperators
{
    using System;
    using Windows.Foundation.Metadata;

    [Guid(0x217700e0, 0x8203, 0x11df, 0xad, 0xb9, 0xf4, 0xce, 70, 0x2d, 0x91, 0x37), ExclusiveTo(typeof(ProvisionFromXmlDocumentResults)), Version(0x6020000)]
    internal interface IProvisionFromXmlDocumentResults
    {
        bool AllElementsProvisioned { get; }

        string ProvisionResultsXml { get; }
    }
}

