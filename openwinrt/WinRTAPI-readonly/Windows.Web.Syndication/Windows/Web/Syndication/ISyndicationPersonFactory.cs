namespace Windows.Web.Syndication
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(SyndicationPerson)), Windows.Foundation.Metadata.Guid(0xdcf4886d, 0x229d, 0x4b58, 0xa4, 0x9b, 0xf3, 210, 240, 0xf5, 0xc9, 0x9f)]
    internal interface ISyndicationPersonFactory
    {
        [Overload("CreateSyndicationPerson")]
        SyndicationPerson CreateSyndicationPerson([In] string name);
        [Overload("CreateSyndicationPersonEx")]
        SyndicationPerson CreateSyndicationPerson([In] string name, [In] string email, [In] Uri uri);
    }
}

