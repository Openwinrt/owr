namespace Windows.UI.Core
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.UI.Popups;

    [Version(0x6020000), ExclusiveTo(typeof(CoreWindowDialog)), Windows.Foundation.Metadata.Guid(0x7d38e75, 0xdfe2, 0x49d8, 0x95, 0xef, 0x61, 0x9e, 0xcc, 0xe1, 5, 0x92), WebHostHidden]
    internal interface ICoreWindowDialog
    {
        event TypedEventHandler<CoreWindow, object> Showing;

        IAsyncOperation<IUICommand> ShowAsync();

        UICommandInvokedHandler BackButtonCommand { get; [param: In] set; }

        uint CancelCommandIndex { get; [param: In] set; }

        IVector<IUICommand> Commands { get; }

        uint DefaultCommandIndex { get; [param: In] set; }

        Size MaxSize { get; }

        Size MinSize { get; }

        string Title { get; [param: In] set; }
    }
}

