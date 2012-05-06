namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.ApplicationModel.DataTransfer;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Navigation;

    [Windows.Foundation.Metadata.Guid(0x5862cc46, 0x1f7d, 0x479b, 0x92, 0xa6, 0xde, 120, 0x58, 0xfe, 0x8d, 0x54), WebHostHidden, Version(0x6020000), ExclusiveTo(typeof(WebView))]
    internal interface IWebView
    {
        event LoadCompletedEventHandler LoadCompleted;

        event NotifyEventHandler ScriptNotify;

        string InvokeScript([In] string scriptName, [In] string[] arguments);
        void Navigate([In] Uri source);
        void NavigateToString([In] string text);

        IIterable<Uri> AllowedScriptNotifyUris { get; [param: In] set; }

        DataPackage DataTransferPackage { get; }

        Uri Source { get; [param: In] set; }
    }
}

