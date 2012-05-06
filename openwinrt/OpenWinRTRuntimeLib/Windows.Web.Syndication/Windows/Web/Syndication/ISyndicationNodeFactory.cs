namespace Windows.Web.Syndication
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x12902188, 0x4acb, 0x49a8, 0xb7, 0x77, 0xa5, 0xeb, 0x92, 0xe1, 0x8a, 0x79), Version(0x6020000), ExclusiveTo(typeof(SyndicationNode))]
    internal interface ISyndicationNodeFactory
    {
        SyndicationNode CreateSyndicationNode([In] string nodeName, [In] string nodeNamespace, [In] string nodeValue);
    }
}

