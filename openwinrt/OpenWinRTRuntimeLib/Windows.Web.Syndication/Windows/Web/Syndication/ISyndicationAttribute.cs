namespace Windows.Web.Syndication
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x71e8f969, 0x526e, 0x4001, 0x9a, 0x91, 0xe8, 0x4f, 0x83, 0x16, 0x1a, 0xb1), ExclusiveTo(typeof(SyndicationAttribute)), Version(0x6020000)]
    internal interface ISyndicationAttribute
    {
        string Name { get; [param: In] set; }

        string Namespace { get; [param: In] set; }

        string Value { get; [param: In] set; }
    }
}

