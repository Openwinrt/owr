namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Version(0x6020000), ExclusiveTo(typeof(SelectorItemAutomationPeer)), Windows.Foundation.Metadata.Guid(0x66d7edfb, 0x786d, 0x4362, 0xa9, 100, 0xeb, 0xfb, 0x21, 0x77, 0x6c, 0x30)]
    internal interface ISelectorItemAutomationPeerFactory
    {
        SelectorItemAutomationPeer CreateInstanceWithParentAndItem([In] object item, [In] SelectorAutomationPeer parent, [In] object outer, out object inner);
    }
}

