namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls.Primitives;

    [WebHostHidden, MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both), Version(0x6020000), Composable(typeof(IScrollBarAutomationPeerFactory), CompositionType.Public, 0x6020000)]
    public class ScrollBarAutomationPeer : RangeBaseAutomationPeer, IScrollBarAutomationPeer
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ScrollBarAutomationPeer([In] ScrollBar owner);
    }
}

