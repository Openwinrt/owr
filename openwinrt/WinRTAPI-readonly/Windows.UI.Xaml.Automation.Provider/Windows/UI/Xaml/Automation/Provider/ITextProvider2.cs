namespace Windows.UI.Xaml.Automation.Provider
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Windows.Foundation.Metadata.Guid(0xdf1d48bc, 0x487, 0x4e7f, 0x9d, 0x5e, 240, 0x9e, 0x77, 0xe4, 0x12, 70), Version(0x6020000)]
    public interface ITextProvider2 : ITextProvider
    {
        ITextRangeProvider GetCaretRange(out bool isActive);
        ITextRangeProvider RangeFromAnnotation([In] IRawElementProviderSimple annotationElement);
    }
}

