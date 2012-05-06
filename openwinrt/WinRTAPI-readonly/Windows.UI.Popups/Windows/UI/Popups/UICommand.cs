namespace Windows.UI.Popups
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Activatable(0x6020000), Activatable(typeof(IUICommandFactory), 0x6020000)]
    public sealed class UICommand : IUICommand
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public UICommand();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public UICommand([In] string label);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public UICommand([In] string label, [In] UICommandInvokedHandler action);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public UICommand([In] string label, [In] UICommandInvokedHandler action, [In, Variant] object commandId);

        public object Id { [return: Variant] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In, Variant] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public UICommandInvokedHandler Invoked { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Label { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public object Windows.UI.Popups.IUICommand.Id { [return: Variant] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In, Variant] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public UICommandInvokedHandler Windows.UI.Popups.IUICommand.Invoked { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.UI.Popups.IUICommand.Label { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

