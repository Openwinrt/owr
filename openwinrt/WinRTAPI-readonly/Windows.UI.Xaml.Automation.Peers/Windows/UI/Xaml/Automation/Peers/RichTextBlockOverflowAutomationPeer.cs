namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls;

    [Version(0x6020000), Threading(ThreadingModel.Both), MarshalingBehavior(MarshalingType.FreeThreaded), WebHostHidden, Composable(typeof(IRichTextBlockOverflowAutomationPeerFactory), CompositionType.Public, 0x6020000)]
    public class RichTextBlockOverflowAutomationPeer : FrameworkElementAutomationPeer, IRichTextBlockOverflowAutomationPeer
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public RichTextBlockOverflowAutomationPeer([In] RichTextBlockOverflow owner);
    }
}

