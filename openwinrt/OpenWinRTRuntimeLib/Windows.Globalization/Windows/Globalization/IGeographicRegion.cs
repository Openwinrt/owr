namespace Windows.Globalization
{
    using System;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(GeographicRegion)), Guid(0x1e9a621, 0x4a64, 0x4ed9, 0x95, 0x4f, 0x9e, 0xde, 0xb0, 0x7b, 0xd9, 3)]
    internal interface IGeographicRegion
    {
        string Code { get; }

        string CodeThreeDigit { get; }

        string CodeThreeLetter { get; }

        string CodeTwoLetter { get; }

        IVectorView<string> CurrenciesInUse { get; }

        string DisplayName { get; }

        string NativeName { get; }
    }
}

