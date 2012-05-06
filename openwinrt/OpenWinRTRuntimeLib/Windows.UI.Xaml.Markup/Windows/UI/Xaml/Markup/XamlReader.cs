namespace Windows.UI.Xaml.Markup
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Threading(ThreadingModel.Both), MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000), Static(typeof(IXamlReaderStatics), 0x6020000)]
    public sealed class XamlReader : IXamlReader
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static object Load([In] string xaml);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static object LoadWithInitialTemplateValidation([In] string xaml);
    }
}

