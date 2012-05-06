namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls;

    [Version(0x6020000), Threading(ThreadingModel.Both), WebHostHidden, Composable(typeof(ICheckBoxAutomationPeerFactory), CompositionType.Public, 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public class CheckBoxAutomationPeer : ToggleButtonAutomationPeer, ICheckBoxAutomationPeer
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public CheckBoxAutomationPeer([In] CheckBox owner);
    }
}

