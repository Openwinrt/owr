namespace Windows.UI.Xaml.Controls
{
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Version(0x6020000), ExclusiveTo(typeof(WebView)), Guid(0xa0b561de, 0x5fdb, 0x443b, 0xb9, 240, 0x5c, 0x30, 0xf6, 0xb7, 0xa1, 0xf4), WebHostHidden]
    internal interface IWebViewStatics
    {
        DependencyProperty AllowedScriptNotifyUrisProperty { get; }

        IIterable<Uri> AnyScriptNotifyUri { get; }

        DependencyProperty DataTransferPackageProperty { get; }

        DependencyProperty SourceProperty { get; }
    }
}

