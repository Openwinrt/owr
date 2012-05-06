namespace Windows.UI.Xaml.Automation.Provider
{
    using Windows.Foundation.Metadata;

    [Guid(0x1133c336, 0xa89b, 0x4130, 0x9b, 230, 0x55, 0xe3, 0x33, 0x34, 0xf5, 0x57), Version(0x6020000), WebHostHidden]
    public interface ITextChildProvider
    {
        IRawElementProviderSimple TextContainer { get; }

        ITextRangeProvider TextRange { get; }
    }
}

