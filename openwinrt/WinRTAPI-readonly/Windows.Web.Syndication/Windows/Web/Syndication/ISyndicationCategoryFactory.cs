namespace Windows.Web.Syndication
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(SyndicationCategory)), Windows.Foundation.Metadata.Guid(0xab42802f, 0x49e0, 0x4525, 0x8a, 0xb2, 0xab, 0x45, 0xc0, 0x25, 40, 0xff)]
    internal interface ISyndicationCategoryFactory
    {
        [Overload("CreateSyndicationCategory")]
        SyndicationCategory CreateSyndicationCategory([In] string term);
        [Overload("CreateSyndicationCategoryEx")]
        SyndicationCategory CreateSyndicationCategory([In] string term, [In] string scheme, [In] string label);
    }
}

