namespace Windows.ApplicationModel.DataTransfer
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), DualApiPartition(version=0x6020000), Static(typeof(IHtmlFormatHelperStatics), 0x6020000)]
    public static class HtmlFormatHelper
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static string CreateHtmlFormat([In] string htmlFragment);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static string GetStaticFragment([In] string htmlFormat);
    }
}

