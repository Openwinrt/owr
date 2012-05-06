namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Media;

    [Version(0x6020000), Static(typeof(IWebViewBrushStatics), 0x6020000), WebHostHidden, MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both), Activatable(0x6020000)]
    public sealed class WebViewBrush : TileBrush, IWebViewBrush
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public WebViewBrush();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Redraw();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SetSource([In] WebView source);

        public string SourceName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty SourceNameProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.UI.Xaml.Controls.IWebViewBrush.SourceName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

