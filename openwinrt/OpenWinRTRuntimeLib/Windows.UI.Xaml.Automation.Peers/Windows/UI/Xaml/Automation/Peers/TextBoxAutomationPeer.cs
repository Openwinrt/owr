namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls;

    [Composable(typeof(ITextBoxAutomationPeerFactory), CompositionType.Public, 0x6020000), Threading(ThreadingModel.Both), WebHostHidden, Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public class TextBoxAutomationPeer : FrameworkElementAutomationPeer, ITextBoxAutomationPeer
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public TextBoxAutomationPeer([In] TextBox owner);
    }
}

