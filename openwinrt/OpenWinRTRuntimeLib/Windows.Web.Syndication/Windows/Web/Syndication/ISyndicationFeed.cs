namespace Windows.Web.Syndication
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Data.Xml.Dom;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x7ffe3cd2, 0x5b66, 0x4d62, 0x84, 3, 0x1b, 0xc1, 13, 0x91, 13, 0x6b), ExclusiveTo(typeof(SyndicationFeed))]
    internal interface ISyndicationFeed : ISyndicationNode
    {
        void Load([In] string feed);
        void LoadFromXml([In] XmlDocument feedDocument);

        IVector<SyndicationPerson> Authors { get; }

        IVector<SyndicationCategory> Categories { get; }

        IVector<SyndicationPerson> Contributors { get; }

        Uri FirstUri { get; }

        SyndicationGenerator Generator { get; [param: In] set; }

        Uri IconUri { get; [param: In] set; }

        string Id { get; [param: In] set; }

        Uri ImageUri { get; [param: In] set; }

        IVector<SyndicationItem> Items { get; }

        Windows.Foundation.DateTime LastUpdatedTime { get; [param: In] set; }

        Uri LastUri { get; }

        IVector<SyndicationLink> Links { get; }

        Uri NextUri { get; }

        Uri PreviousUri { get; }

        ISyndicationText Rights { get; [param: In] set; }

        SyndicationFormat SourceFormat { get; }

        ISyndicationText Subtitle { get; [param: In] set; }

        ISyndicationText Title { get; [param: In] set; }
    }
}

