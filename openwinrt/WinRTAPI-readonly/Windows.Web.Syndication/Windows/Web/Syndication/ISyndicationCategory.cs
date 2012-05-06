namespace Windows.Web.Syndication
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(SyndicationCategory)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0x8715626f, 0xcba, 0x4a7f, 0x89, 0xff, 0xec, 0xb5, 40, 20, 0x23, 0xb6)]
    internal interface ISyndicationCategory : ISyndicationNode
    {
        string Label { get; [param: In] set; }

        string Scheme { get; [param: In] set; }

        string Term { get; [param: In] set; }
    }
}

