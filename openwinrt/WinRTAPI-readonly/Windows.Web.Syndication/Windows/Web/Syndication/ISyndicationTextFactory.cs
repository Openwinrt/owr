namespace Windows.Web.Syndication
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xee7342f7, 0x11c6, 0x4b25, 0xab, 0x62, 0xe5, 150, 0xbd, 0x16, 0x29, 70), Version(0x6020000), ExclusiveTo(typeof(SyndicationText))]
    internal interface ISyndicationTextFactory
    {
        [Overload("CreateSyndicationText")]
        SyndicationText CreateSyndicationText([In] string text);
        [Overload("CreateSyndicationTextEx")]
        SyndicationText CreateSyndicationText([In] string text, [In] SyndicationTextType type);
    }
}

