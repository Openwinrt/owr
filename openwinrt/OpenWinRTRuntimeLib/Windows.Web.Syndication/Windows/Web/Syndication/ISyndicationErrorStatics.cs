namespace Windows.Web.Syndication
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x1fbb2361, 0x45c7, 0x4833, 0x8a, 160, 190, 0x5f, 0x3b, 0x58, 0xa7, 0xf4), ExclusiveTo(typeof(SyndicationError))]
    internal interface ISyndicationErrorStatics
    {
        SyndicationErrorStatus GetStatus([In] int hresult);
    }
}

