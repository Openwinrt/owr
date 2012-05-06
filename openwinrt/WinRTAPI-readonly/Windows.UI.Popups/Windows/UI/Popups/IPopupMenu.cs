namespace Windows.UI.Popups
{
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(PopupMenu)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0x4e9bc6dc, 0x880d, 0x47fc, 160, 0xa1, 0x72, 0xb6, 0x39, 230, 0x25, 0x59)]
    internal interface IPopupMenu
    {
        IAsyncOperation<IUICommand> ShowAsync([In] Point invocationPoint);
        [Overload("ShowAsyncWithRect")]
        IAsyncOperation<IUICommand> ShowForSelectionAsync([In] Rect selection);
        [Overload("ShowAsyncWithRectAndPlacement")]
        IAsyncOperation<IUICommand> ShowForSelectionAsync([In] Rect selection, [In] Placement preferredPlacement);

        IVector<IUICommand> Commands { get; }
    }
}

