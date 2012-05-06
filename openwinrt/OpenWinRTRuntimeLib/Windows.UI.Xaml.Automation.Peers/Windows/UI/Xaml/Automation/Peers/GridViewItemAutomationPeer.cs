namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls;

    [Version(0x6020000), Composable(typeof(IGridViewItemAutomationPeerFactory), CompositionType.Public, 0x6020000), Threading(ThreadingModel.Both), WebHostHidden, MarshalingBehavior(MarshalingType.FreeThreaded)]
    public class GridViewItemAutomationPeer : FrameworkElementAutomationPeer, IGridViewItemAutomationPeer
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public GridViewItemAutomationPeer([In] GridViewItem owner);
    }
}

