namespace Windows.Graphics.Printing.OptionDetails
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(PrintTaskOptionDetails)), Windows.Foundation.Metadata.Guid(0xf5720af1, 0xa89e, 0x42a6, 0x81, 0xaf, 0xf8, 0xe0, 0x10, 0xb3, 0x8a, 0x68), Version(0x6020000)]
    internal interface IPrintTaskOptionDetails
    {
        event TypedEventHandler<PrintTaskOptionDetails, object> BeginValidation;

        event TypedEventHandler<PrintTaskOptionDetails, PrintTaskOptionChangedEventArgs> OptionChanged;

        PrintCustomItemListOptionDetails CreateItemListOption([In] string optionId, [In] string displayName);
        PrintCustomTextOptionDetails CreateTextOption([In] string optionId, [In] string displayName);

        IMapView<string, IPrintOptionDetails> Options { get; }
    }
}

