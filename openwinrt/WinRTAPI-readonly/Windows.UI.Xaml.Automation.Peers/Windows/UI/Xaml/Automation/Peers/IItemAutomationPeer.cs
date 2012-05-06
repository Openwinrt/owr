namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using Windows.Foundation.Metadata;

    [Guid(0x953c34f6, 0x3b31, 0x47a7, 0xb3, 0xbf, 0x25, 0xd3, 0xae, 0x99, 0xc3, 0x17), ExclusiveTo(typeof(ItemAutomationPeer)), WebHostHidden, Version(0x6020000)]
    internal interface IItemAutomationPeer
    {
        object Item { get; }

        Windows.UI.Xaml.Automation.Peers.ItemsControlAutomationPeer ItemsControlAutomationPeer { get; }
    }
}

