namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.ApplicationModel.DataTransfer;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Navigation;

    [WebHostHidden, Static(typeof(IWebViewStatics), 0x6020000), Threading(ThreadingModel.Both), Version(0x6020000), Activatable(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class WebView : FrameworkElement, IWebView
    {
        public event LoadCompletedEventHandler LoadCompleted;

        public event NotifyEventHandler ScriptNotify;

        public event LoadCompletedEventHandler Windows.UI.Xaml.Controls.IWebView.LoadCompleted;

        public event NotifyEventHandler Windows.UI.Xaml.Controls.IWebView.ScriptNotify;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public WebView();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public string InvokeScript([In] string scriptName, [In] string[] arguments);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Navigate([In] Uri source);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void NavigateToString([In] string text);

        public IIterable<Uri> AllowedScriptNotifyUris { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty AllowedScriptNotifyUrisProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static IIterable<Uri> AnyScriptNotifyUri { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public DataPackage DataTransferPackage { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty DataTransferPackageProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Uri Source { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty SourceProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IIterable<Uri> Windows.UI.Xaml.Controls.IWebView.AllowedScriptNotifyUris { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public DataPackage Windows.UI.Xaml.Controls.IWebView.DataTransferPackage { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Uri Windows.UI.Xaml.Controls.IWebView.Source { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

