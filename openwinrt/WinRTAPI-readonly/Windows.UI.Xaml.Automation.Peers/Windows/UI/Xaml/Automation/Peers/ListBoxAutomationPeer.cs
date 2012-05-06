namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls;

    [Threading(ThreadingModel.Both), MarshalingBehavior(MarshalingType.FreeThreaded), WebHostHidden, Composable(typeof(IListBoxAutomationPeerFactory), CompositionType.Public, 0x6020000), Version(0x6020000)]
    public class ListBoxAutomationPeer : SelectorAutomationPeer, IListBoxAutomationPeer
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ListBoxAutomationPeer([In] ListBox owner);
    }
}

