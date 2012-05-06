namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls.Primitives;

    [WebHostHidden, Threading(ThreadingModel.Both), Version(0x6020000), Composable(typeof(IVirtualizingPanelFactory), CompositionType.Protected, 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public class VirtualizingPanel : Panel, IVirtualizingPanel, IVirtualizingPanelOverrides, IVirtualizingPanelProtected
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected VirtualizingPanel();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected void AddInternalChild([In] UIElement child);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual void BringIndexIntoView([In] int index);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected void InsertInternalChild([In] int index, [In] UIElement child);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual void OnClearChildren();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual void OnItemsChanged([In] object sender, [In] ItemsChangedEventArgs args);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected void RemoveInternalChildRange([In] int index, [In] int range);

        public Windows.UI.Xaml.Controls.Primitives.IItemContainerGenerator ItemContainerGenerator { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Controls.Primitives.IItemContainerGenerator Windows.UI.Xaml.Controls.IVirtualizingPanel.ItemContainerGenerator { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

