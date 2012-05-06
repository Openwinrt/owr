namespace Windows.Web.Syndication
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xfa1ee5da, 0xa7c6, 0x4517, 160, 150, 1, 0x43, 250, 0xf2, 0x93, 0x27), ExclusiveTo(typeof(SyndicationPerson)), Version(0x6020000)]
    internal interface ISyndicationPerson : ISyndicationNode
    {
        string Email { get; [param: In] set; }

        string Name { get; [param: In] set; }

        Windows.Foundation.Uri Uri { get; [param: In] set; }
    }
}

