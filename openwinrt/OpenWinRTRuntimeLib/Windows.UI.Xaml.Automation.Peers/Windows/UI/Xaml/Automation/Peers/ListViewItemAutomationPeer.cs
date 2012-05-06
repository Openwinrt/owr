namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls;

    [Threading(ThreadingModel.Both), WebHostHidden, Version(0x6020000), Composable(typeof(IListViewItemAutomationPeerFactory), CompositionType.Public, 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public class ListViewItemAutomationPeer : FrameworkElementAutomationPeer, IListViewItemAutomationPeer
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ListViewItemAutomationPeer([In] ListViewItem owner);
    }
}

