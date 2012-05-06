namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x8360f4e2, 0xe396, 0x4517, 0xaf, 0x5d, 0xf4, 0xcf, 0x34, 0xc5, 0x4e, 0xdf), ExclusiveTo(typeof(AppBarAutomationPeer)), WebHostHidden]
    internal interface IAppBarAutomationPeerFactory
    {
        AppBarAutomationPeer CreateInstanceWithOwner([In] AppBar owner, [In] object outer, out object inner);
    }
}

