namespace Windows.UI.Popups
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Activatable(0x6020000)]
    public sealed class PopupMenu : IPopupMenu
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public PopupMenu();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperation<IUICommand> ShowAsync([In] Point invocationPoint);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("ShowAsyncWithRect")]
        public IAsyncOperation<IUICommand> ShowForSelectionAsync([In] Rect selection);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("ShowAsyncWithRectAndPlacement")]
        public IAsyncOperation<IUICommand> ShowForSelectionAsync([In] Rect selection, [In] Placement preferredPlacement);

        public IVector<IUICommand> Commands { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVector<IUICommand> Windows.UI.Popups.IPopupMenu.Commands { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

