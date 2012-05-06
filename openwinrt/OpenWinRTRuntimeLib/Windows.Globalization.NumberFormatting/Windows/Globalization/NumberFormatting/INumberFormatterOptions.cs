namespace Windows.Globalization.NumberFormatting
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x80332d21, 0xaee1, 0x4a39, 0xba, 0xa2, 7, 0xed, 140, 150, 0xda, 0xf6)]
    public interface INumberFormatterOptions
    {
        int FractionDigits { get; [param: In] set; }

        string GeographicRegion { get; }

        int IntegerDigits { get; [param: In] set; }

        bool IsDecimalPointAlwaysDisplayed { get; [param: In] set; }

        bool IsGrouped { get; [param: In] set; }

        IVectorView<string> Languages { get; }

        string NumeralSystem { get; [param: In] set; }
    }
}

