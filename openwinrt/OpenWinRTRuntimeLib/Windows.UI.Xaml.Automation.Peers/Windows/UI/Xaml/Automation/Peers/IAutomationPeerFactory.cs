namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(AutomationPeer)), WebHostHidden, Windows.Foundation.Metadata.Guid(0x20c27545, 0xa88b, 0x43c8, 0xbc, 0x24, 0xce, 0xa9, 0xda, 0xfd, 4, 0xa3)]
    internal interface IAutomationPeerFactory
    {
        AutomationPeer CreateInstance([In] object outer, out object inner);
    }
}

