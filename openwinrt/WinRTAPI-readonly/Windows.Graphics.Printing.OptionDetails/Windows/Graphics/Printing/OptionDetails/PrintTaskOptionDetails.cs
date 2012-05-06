namespace Windows.Graphics.Printing.OptionDetails
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.Graphics.Printing;

    [Static(typeof(IPrintTaskOptionDetailsStatic), 0x6020000), Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class PrintTaskOptionDetails : IPrintTaskOptionDetails, IPrintTaskOptionsCore, IPrintTaskOptionsCoreUIConfiguration
    {
        public event TypedEventHandler<PrintTaskOptionDetails, object> BeginValidation;

        public event TypedEventHandler<PrintTaskOptionDetails, PrintTaskOptionChangedEventArgs> OptionChanged;

        public event TypedEventHandler<PrintTaskOptionDetails, object> Windows.Graphics.Printing.OptionDetails.IPrintTaskOptionDetails.BeginValidation;

        public event TypedEventHandler<PrintTaskOptionDetails, PrintTaskOptionChangedEventArgs> Windows.Graphics.Printing.OptionDetails.IPrintTaskOptionDetails.OptionChanged;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public PrintCustomItemListOptionDetails CreateItemListOption([In] string optionId, [In] string displayName);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public PrintCustomTextOptionDetails CreateTextOption([In] string optionId, [In] string displayName);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static PrintTaskOptionDetails GetFromPrintTaskOptions([In] PrintTaskOptions printTaskOptions);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public PrintPageDescription GetPageDescription([In] uint jobPageNumber);

        public IVector<string> DisplayedOptions { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IMapView<string, IPrintOptionDetails> Options { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVector<string> Windows.Graphics.Printing.IPrintTaskOptionsCoreUIConfiguration.DisplayedOptions { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IMapView<string, IPrintOptionDetails> Windows.Graphics.Printing.OptionDetails.IPrintTaskOptionDetails.Options { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

