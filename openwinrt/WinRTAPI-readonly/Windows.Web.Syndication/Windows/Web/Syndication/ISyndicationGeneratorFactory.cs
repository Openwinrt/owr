namespace Windows.Web.Syndication
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xa34083e3, 0x1e26, 0x4dbc, 0xba, 0x9d, 0x1a, 0xb8, 0x4b, 0xef, 0xf9, 0x7b), ExclusiveTo(typeof(SyndicationGenerator)), Version(0x6020000)]
    internal interface ISyndicationGeneratorFactory
    {
        SyndicationGenerator CreateSyndicationGenerator([In] string text);
    }
}

