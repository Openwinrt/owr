namespace Windows.Web.Syndication
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Data.Xml.Dom;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(SyndicationItem)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0x548db883, 0xc384, 0x45c1, 0x8a, 0xe8, 0xa3, 120, 0xc4, 0xec, 0x48, 0x6c)]
    internal interface ISyndicationItem : ISyndicationNode
    {
        void Load([In] string item);
        void LoadFromXml([In] XmlDocument itemDocument);

        IVector<SyndicationPerson> Authors { get; }

        IVector<SyndicationCategory> Categories { get; }

        Uri CommentsUri { get; [param: In] set; }

        SyndicationContent Content { get; [param: In] set; }

        IVector<SyndicationPerson> Contributors { get; }

        Uri EditMediaUri { get; }

        Uri EditUri { get; }

        string ETag { get; }

        string Id { get; [param: In] set; }

        Uri ItemUri { get; }

        Windows.Foundation.DateTime LastUpdatedTime { get; [param: In] set; }

        IVector<SyndicationLink> Links { get; }

        Windows.Foundation.DateTime PublishedDate { get; [param: In] set; }

        ISyndicationText Rights { get; [param: In] set; }

        SyndicationFeed Source { get; [param: In] set; }

        ISyndicationText Summary { get; [param: In] set; }

        ISyndicationText Title { get; [param: In] set; }
    }
}

