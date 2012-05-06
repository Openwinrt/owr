namespace Windows.UI.Popups
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Activatable(typeof(IMessageDialogFactory), 0x6020000), Version(0x6020000)]
    public sealed class MessageDialog : IMessageDialog
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public MessageDialog([In] string content);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public MessageDialog([In] string content, [In] string title);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperation<IUICommand> ShowAsync();

        public uint CancelCommandIndex { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IVector<IUICommand> Commands { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Content { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public uint DefaultCommandIndex { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Title { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public uint Windows.UI.Popups.IMessageDialog.CancelCommandIndex { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IVector<IUICommand> Windows.UI.Popups.IMessageDialog.Commands { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.UI.Popups.IMessageDialog.Content { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public uint Windows.UI.Popups.IMessageDialog.DefaultCommandIndex { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.UI.Popups.IMessageDialog.Title { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

