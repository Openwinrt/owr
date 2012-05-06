namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls;

    [Version(0x6020000), WebHostHidden, MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both), Composable(typeof(IProgressRingAutomationPeerFactory), CompositionType.Public, 0x6020000)]
    public class ProgressRingAutomationPeer : FrameworkElementAutomationPeer, IProgressRingAutomationPeer
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ProgressRingAutomationPeer([In] ProgressRing owner);
    }
}

