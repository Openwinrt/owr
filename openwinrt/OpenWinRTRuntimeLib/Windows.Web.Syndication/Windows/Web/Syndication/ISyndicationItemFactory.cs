namespace Windows.Web.Syndication
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(SyndicationItem)), Windows.Foundation.Metadata.Guid(0x251d434f, 0x7db8, 0x487a, 0x85, 0xe4, 0x10, 0xd1, 0x91, 230, 110, 0xbb)]
    internal interface ISyndicationItemFactory
    {
        SyndicationItem CreateSyndicationItem([In] string title, [In] SyndicationContent content, [In] Uri uri);
    }
}

