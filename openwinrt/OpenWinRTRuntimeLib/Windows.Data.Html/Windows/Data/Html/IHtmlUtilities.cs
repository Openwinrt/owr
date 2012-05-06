namespace Windows.Data.Html
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Version(0x6020000), Windows.Foundation.Metadata.Guid(0xfec00add, 0x2399, 0x4fac, 0xb5, 0xa7, 5, 0xe9, 0xac, 0xd7, 0x18, 0x1d), ExclusiveTo(typeof(HtmlUtilities))]
    internal interface IHtmlUtilities
    {
        string ConvertToText([In] string html);
    }
}

