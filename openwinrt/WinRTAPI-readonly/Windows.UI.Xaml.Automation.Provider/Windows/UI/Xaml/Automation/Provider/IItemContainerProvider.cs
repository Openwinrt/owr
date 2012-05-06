namespace Windows.UI.Xaml.Automation.Provider
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Automation;

    [Windows.Foundation.Metadata.Guid(0xef5cd845, 0xe1d4, 0x40f4, 0xba, 0xd5, 0xc7, 250, 0xd4, 0x4a, 0x70, 0x3e), Version(0x6020000), WebHostHidden]
    public interface IItemContainerProvider
    {
        IRawElementProviderSimple FindItemByProperty([In] IRawElementProviderSimple startAfter, [In] AutomationProperty property, [In] object value);
    }
}

