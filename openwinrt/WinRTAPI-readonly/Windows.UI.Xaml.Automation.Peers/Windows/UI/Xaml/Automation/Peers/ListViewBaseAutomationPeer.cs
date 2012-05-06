namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Automation.Provider;
    using Windows.UI.Xaml.Controls;

    [Threading(ThreadingModel.Both), WebHostHidden, Composable(typeof(IListViewBaseAutomationPeerFactory), CompositionType.Public, 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000)]
    public class ListViewBaseAutomationPeer : SelectorAutomationPeer, IListViewBaseAutomationPeer, IDropTargetProvider
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ListViewBaseAutomationPeer([In] ListViewBase owner);

        public string DropEffect { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string[] DropEffects { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.UI.Xaml.Automation.Provider.IDropTargetProvider.DropEffect { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string[] Windows.UI.Xaml.Automation.Provider.IDropTargetProvider.DropEffects { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

