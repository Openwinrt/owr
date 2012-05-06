namespace Windows.UI.Xaml.Automation.Provider
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Automation;

    [WebHostHidden, Guid(0x7a8ed399, 0x6824, 0x4595, 0xba, 0xb3, 70, 0x4b, 0xc9, 160, 0x44, 0x17), Version(0x6020000)]
    public interface ITableProvider
    {
        IRawElementProviderSimple[] GetColumnHeaders();
        IRawElementProviderSimple[] GetRowHeaders();

        Windows.UI.Xaml.Automation.RowOrColumnMajor RowOrColumnMajor { get; }
    }
}

