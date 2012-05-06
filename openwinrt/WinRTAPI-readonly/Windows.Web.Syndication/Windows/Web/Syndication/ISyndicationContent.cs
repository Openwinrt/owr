namespace Windows.Web.Syndication
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x4641fefe, 0xe55, 0x40d0, 0xb8, 0xd0, 0x6a, 0x2c, 0xcb, 0xa9, 0xfc, 0x7c), ExclusiveTo(typeof(SyndicationContent)), Version(0x6020000)]
    internal interface ISyndicationContent : ISyndicationText, ISyndicationNode
    {
        Uri SourceUri { get; [param: In] set; }
    }
}

