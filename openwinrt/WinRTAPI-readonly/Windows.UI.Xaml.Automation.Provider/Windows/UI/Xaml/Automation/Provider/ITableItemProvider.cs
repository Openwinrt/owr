namespace Windows.UI.Xaml.Automation.Provider
{
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0x3b2c49cd, 0x1de2, 0x4ee2, 0xa3, 0xe1, 0xfb, 0x55, 0x35, 0x59, 0xd1, 0x5d), WebHostHidden]
    public interface ITableItemProvider
    {
        IRawElementProviderSimple[] GetColumnHeaderItems();
        IRawElementProviderSimple[] GetRowHeaderItems();
    }
}

