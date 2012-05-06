namespace Windows.Data.Html
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Threading(ThreadingModel.Both), WebHostHidden, Static(typeof(IHtmlUtilities), 0x6020000)]
    public static class HtmlUtilities
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static string ConvertToText([In] string html);
    }
}

