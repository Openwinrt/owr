namespace Windows.Web.Syndication
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(SyndicationAttribute)), Windows.Foundation.Metadata.Guid(0x624f1599, 0xed3e, 0x420f, 190, 0x86, 100, 4, 20, 0x88, 110, 0x4b)]
    internal interface ISyndicationAttributeFactory
    {
        SyndicationAttribute CreateSyndicationAttribute([In] string attributeName, [In] string attributeNamespace, [In] string attributeValue);
    }
}

