namespace Windows.Globalization.NumberFormatting
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(CurrencyFormatter)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0x11730ca5, 0x4b00, 0x41b2, 0xb3, 50, 0x73, 0xb1, 0x2a, 0x49, 0x7d, 0x54)]
    internal interface ICurrencyFormatter : INumberFormatterOptions, INumberFormatter, INumberParser
    {
        string Currency { get; [param: In] set; }
    }
}

