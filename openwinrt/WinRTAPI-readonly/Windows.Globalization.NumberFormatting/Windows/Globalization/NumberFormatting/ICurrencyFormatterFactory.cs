namespace Windows.Globalization.NumberFormatting
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(CurrencyFormatter)), Windows.Foundation.Metadata.Guid(0x86c7537e, 0xb938, 0x4aa2, 0x84, 0xb0, 0x2c, 0x33, 220, 0x5b, 20, 80)]
    internal interface ICurrencyFormatterFactory
    {
        CurrencyFormatter CreateCurrencyFormatterCode([In] string currencyCode);
        CurrencyFormatter CreateCurrencyFormatterCodeContext([In] string currencyCode, [In] IIterable<string> languages, [In] string geographicRegion);
    }
}

