namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls;

    [Threading(ThreadingModel.Both), MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000), Composable(typeof(IGroupItemAutomationPeerFactory), CompositionType.Public, 0x6020000), WebHostHidden]
    public class GroupItemAutomationPeer : FrameworkElementAutomationPeer, IGroupItemAutomationPeer
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public GroupItemAutomationPeer([In] GroupItem owner);
    }
}

