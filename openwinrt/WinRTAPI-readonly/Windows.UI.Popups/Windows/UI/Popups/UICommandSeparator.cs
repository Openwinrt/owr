namespace Windows.UI.Popups
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Activatable(0x6020000), Version(0x6020000)]
    public sealed class UICommandSeparator : IUICommand
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public UICommandSeparator();

        public object Id { [return: Variant] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In, Variant] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public UICommandInvokedHandler Invoked { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Label { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public object Windows.UI.Popups.IUICommand.Id { [return: Variant] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In, Variant] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public UICommandInvokedHandler Windows.UI.Popups.IUICommand.Invoked { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.UI.Popups.IUICommand.Label { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

