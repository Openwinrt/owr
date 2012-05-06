namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000), Composable(typeof(IListViewAutomationPeerFactory), CompositionType.Public, 0x6020000), Threading(ThreadingModel.Both), WebHostHidden]
    public class ListViewAutomationPeer : ListViewBaseAutomationPeer, IListViewAutomationPeer
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ListViewAutomationPeer([In] ListView owner);
    }
}

