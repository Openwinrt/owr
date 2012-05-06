namespace Windows.UI.Core
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.UI.Popups;

    [Activatable(0x6020000), WebHostHidden, Activatable(typeof(ICoreWindowDialogFactory), 0x6020000), Version(0x6020000)]
    public sealed class CoreWindowDialog : ICoreWindowDialog
    {
        public event TypedEventHandler<CoreWindow, object> Showing;

        public event TypedEventHandler<CoreWindow, object> Windows.UI.Core.ICoreWindowDialog.Showing;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public CoreWindowDialog();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public CoreWindowDialog([In] string title);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperation<IUICommand> ShowAsync();

        public UICommandInvokedHandler BackButtonCommand { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public uint CancelCommandIndex { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IVector<IUICommand> Commands { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint DefaultCommandIndex { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Size MaxSize { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Size MinSize { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Title { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public UICommandInvokedHandler Windows.UI.Core.ICoreWindowDialog.BackButtonCommand { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public uint Windows.UI.Core.ICoreWindowDialog.CancelCommandIndex { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IVector<IUICommand> Windows.UI.Core.ICoreWindowDialog.Commands { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.UI.Core.ICoreWindowDialog.DefaultCommandIndex { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Size Windows.UI.Core.ICoreWindowDialog.MaxSize { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Size Windows.UI.Core.ICoreWindowDialog.MinSize { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.UI.Core.ICoreWindowDialog.Title { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

