namespace Windows.Globalization.NumberFormatting
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000), DualApiPartition(version=0x6020000), Activatable(typeof(ICurrencyFormatterFactory), 0x6020000), Threading(ThreadingModel.Both)]
    public sealed class CurrencyFormatter : ICurrencyFormatter, INumberFormatterOptions, INumberFormatter, INumberParser
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public CurrencyFormatter([In] string currencyCode);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public CurrencyFormatter([In] string currencyCode, [In] IIterable<string> languages, [In] string geographicRegion);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("FormatDouble"), DefaultOverload]
        public string Format([In] double value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("FormatInt")]
        public string Format([In] long value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("FormatUInt")]
        public string Format([In] ulong value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IReference<double> ParseDouble([In] string text);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IReference<long> ParseInt([In] string text);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IReference<ulong> ParseUInt([In] string text);

        public string Currency { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public int FractionDigits { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string GeographicRegion { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int IntegerDigits { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool IsDecimalPointAlwaysDisplayed { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool IsGrouped { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IVectorView<string> Languages { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string NumeralSystem { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.Globalization.NumberFormatting.ICurrencyFormatter.Currency { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public int Windows.Globalization.NumberFormatting.INumberFormatterOptions.FractionDigits { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.Globalization.NumberFormatting.INumberFormatterOptions.GeographicRegion { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int Windows.Globalization.NumberFormatting.INumberFormatterOptions.IntegerDigits { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.Globalization.NumberFormatting.INumberFormatterOptions.IsDecimalPointAlwaysDisplayed { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.Globalization.NumberFormatting.INumberFormatterOptions.IsGrouped { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IVectorView<string> Windows.Globalization.NumberFormatting.INumberFormatterOptions.Languages { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Globalization.NumberFormatting.INumberFormatterOptions.NumeralSystem { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

