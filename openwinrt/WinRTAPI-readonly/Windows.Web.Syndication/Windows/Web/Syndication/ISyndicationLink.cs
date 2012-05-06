namespace Windows.Web.Syndication
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x27553abd, 0xa10e, 0x41b5, 0x86, 0xbd, 0x97, 0x59, 8, 110, 0xb0, 0xc5), Version(0x6020000), ExclusiveTo(typeof(SyndicationLink))]
    internal interface ISyndicationLink : ISyndicationNode
    {
        uint Length { get; [param: In] set; }

        string MediaType { get; [param: In] set; }

        string Relationship { get; [param: In] set; }

        string ResourceLanguage { get; [param: In] set; }

        string Title { get; [param: In] set; }

        Windows.Foundation.Uri Uri { get; [param: In] set; }
    }
}

