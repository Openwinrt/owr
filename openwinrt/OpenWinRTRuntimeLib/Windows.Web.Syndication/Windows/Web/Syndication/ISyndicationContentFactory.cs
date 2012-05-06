namespace Windows.Web.Syndication
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x3d2fbb93, 0x9520, 0x4173, 0x93, 0x88, 0x7e, 0x2d, 0xf3, 0x24, 0xa8, 160), Version(0x6020000), ExclusiveTo(typeof(SyndicationContent))]
    internal interface ISyndicationContentFactory
    {
        [Overload("CreateSyndicationContentWithSourceUri")]
        SyndicationContent CreateSyndicationContent([In] Uri sourceUri);
        [Overload("CreateSyndicationContent")]
        SyndicationContent CreateSyndicationContent([In] string text, [In] SyndicationTextType type);
    }
}

