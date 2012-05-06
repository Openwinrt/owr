namespace Windows.UI.Xaml.Automation.Provider
{
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Automation;

    [WebHostHidden, Windows.Foundation.Metadata.Guid(0xdb5bbc9f, 0x4807, 0x4f2a, 0x86, 120, 0x1b, 0x13, 0xf3, 0xc6, 14, 0x22), Version(0x6020000)]
    public interface ITextProvider
    {
        ITextRangeProvider[] GetSelection();
        ITextRangeProvider[] GetVisibleRanges();
        ITextRangeProvider RangeFromChild([In] IRawElementProviderSimple childElement);
        ITextRangeProvider RangeFromPoint([In] Point screenLocation);

        ITextRangeProvider DocumentRange { get; }

        Windows.UI.Xaml.Automation.SupportedTextSelection SupportedTextSelection { get; }
    }
}

