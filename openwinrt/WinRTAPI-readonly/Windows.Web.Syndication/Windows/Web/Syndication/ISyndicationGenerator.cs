namespace Windows.Web.Syndication
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x9768b379, 0xfb2b, 0x4f6d, 180, 0x1c, 8, 0x8a, 0x58, 0x68, 130, 0x5c), Version(0x6020000), ExclusiveTo(typeof(SyndicationGenerator))]
    internal interface ISyndicationGenerator
    {
        string Text { get; [param: In] set; }

        Windows.Foundation.Uri Uri { get; [param: In] set; }

        string Version { get; [param: In] set; }
    }
}

