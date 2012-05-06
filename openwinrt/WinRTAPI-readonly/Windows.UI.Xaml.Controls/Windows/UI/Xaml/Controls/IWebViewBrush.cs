namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(WebViewBrush)), WebHostHidden, Windows.Foundation.Metadata.Guid(0x40e86f75, 0xcf4, 0x4b72, 0xa4, 0xd6, 0xcf, 0x5d, 0x15, 120, 1, 0x16)]
    internal interface IWebViewBrush
    {
        void Redraw();
        void SetSource([In] WebView source);

        string SourceName { get; [param: In] set; }
    }
}

