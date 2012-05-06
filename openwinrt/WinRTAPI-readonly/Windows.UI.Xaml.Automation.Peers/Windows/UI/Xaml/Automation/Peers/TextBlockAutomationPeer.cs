namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls;

    [Threading(ThreadingModel.Both), MarshalingBehavior(MarshalingType.FreeThreaded), WebHostHidden, Version(0x6020000), Composable(typeof(ITextBlockAutomationPeerFactory), CompositionType.Public, 0x6020000)]
    public class TextBlockAutomationPeer : FrameworkElementAutomationPeer, ITextBlockAutomationPeer
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public TextBlockAutomationPeer([In] TextBlock owner);
    }
}

