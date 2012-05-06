namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls;

    [WebHostHidden, Threading(ThreadingModel.Both), Composable(typeof(IRichTextBlockAutomationPeerFactory), CompositionType.Public, 0x6020000), Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public class RichTextBlockAutomationPeer : FrameworkElementAutomationPeer, IRichTextBlockAutomationPeer
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public RichTextBlockAutomationPeer([In] RichTextBlock owner);
    }
}

