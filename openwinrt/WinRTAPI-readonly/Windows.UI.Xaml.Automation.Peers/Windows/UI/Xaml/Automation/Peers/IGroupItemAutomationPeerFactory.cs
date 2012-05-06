namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls;

    [WebHostHidden, Version(0x6020000), Windows.Foundation.Metadata.Guid(0x56a64567, 0xf21c, 0x4c90, 0xb3, 0x79, 0x15, 0xa2, 0x7c, 0x7f, 0x84, 9), ExclusiveTo(typeof(GroupItemAutomationPeer))]
    internal interface IGroupItemAutomationPeerFactory
    {
        GroupItemAutomationPeer CreateInstanceWithOwner([In] GroupItem owner, [In] object outer, out object inner);
    }
}

