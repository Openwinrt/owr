namespace Windows.UI.Core
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.UI.Popups;

    [WebHostHidden, ExclusiveTo(typeof(CoreWindowFlyout)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0xd23a50fc, 0xcfab, 0x4554, 0x90, 0xf2, 0x55, 0xec, 0x90, 120, 0xcb, 0xc5)]
    internal interface ICoreWindowFlyout
    {
        event TypedEventHandler<CoreWindow, object> Showing;

        IAsyncOperation<IUICommand> ShowAsync();

        UICommandInvokedHandler BackButtonCommand { get; [param: In] set; }

        IVector<IUICommand> Commands { get; }

        uint DefaultCommandIndex { get; [param: In] set; }

        Size MaxSize { get; }

        Size MinSize { get; }

        string Title { get; [param: In] set; }
    }
}

