namespace Windows.Web.Syndication
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(SyndicationFeed)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0x23472232, 0x8be9, 0x48b7, 0x89, 0x34, 0x62, 5, 0x13, 0x1d, 0x93, 0x57)]
    internal interface ISyndicationFeedFactory
    {
        SyndicationFeed CreateSyndicationFeed([In] string title, [In] string subtitle, [In] Uri uri);
    }
}

