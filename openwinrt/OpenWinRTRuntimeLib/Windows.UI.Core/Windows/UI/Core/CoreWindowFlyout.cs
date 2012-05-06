namespace Windows.UI.Core
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.UI.Popups;

    [Activatable(typeof(ICoreWindowFlyoutFactory), 0x6020000), Version(0x6020000), WebHostHidden]
    public sealed class CoreWindowFlyout : ICoreWindowFlyout
    {
        public event TypedEventHandler<CoreWindow, object> Showing;

        public event TypedEventHandler<CoreWindow, object> Windows.UI.Core.ICoreWindowFlyout.Showing;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public CoreWindowFlyout([In] Point position);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public CoreWindowFlyout([In] Point position, [In] string title);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperation<IUICommand> ShowAsync();

        public UICommandInvokedHandler BackButtonCommand { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IVector<IUICommand> Commands { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint DefaultCommandIndex { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Size MaxSize { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Size MinSize { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Title { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public UICommandInvokedHandler Windows.UI.Core.ICoreWindowFlyout.BackButtonCommand { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IVector<IUICommand> Windows.UI.Core.ICoreWindowFlyout.Commands { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.UI.Core.ICoreWindowFlyout.DefaultCommandIndex { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Size Windows.UI.Core.ICoreWindowFlyout.MaxSize { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Size Windows.UI.Core.ICoreWindowFlyout.MinSize { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.UI.Core.ICoreWindowFlyout.Title { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

