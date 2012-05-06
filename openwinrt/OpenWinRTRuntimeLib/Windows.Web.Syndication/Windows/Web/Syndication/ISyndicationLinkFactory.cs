namespace Windows.Web.Syndication
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(SyndicationLink)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0x5ed863d4, 0x5535, 0x48ac, 0x98, 0xd4, 0xc1, 0x90, 0x99, 80, 0x80, 0xb3)]
    internal interface ISyndicationLinkFactory
    {
        [Overload("CreateSyndicationLink")]
        SyndicationLink CreateSyndicationLink([In] Uri uri);
        [Overload("CreateSyndicationLinkEx")]
        SyndicationLink CreateSyndicationLink([In] Uri uri, [In] string relationship, [In] string title, [In] string mediaType, [In] uint length);
    }
}

