namespace Windows.UI.Text
{
    using System;
    using Windows.Foundation.Metadata;
    using Windows.UI;

    [ExclusiveTo(typeof(TextConstants)), Guid(0x779e7c33, 0x189d, 0x4bfa, 0x97, 200, 0x10, 0xdb, 0x13, 0x5d, 0x97, 110), Version(0x6020000)]
    internal interface ITextConstantsStatics
    {
        Color AutoColor { get; }

        int MaxUnitCount { get; }

        int MinUnitCount { get; }

        Color UndefinedColor { get; }

        float UndefinedFloatValue { get; }

        FontStretch UndefinedFontStretch { get; }

        FontStyle UndefinedFontStyle { get; }

        int UndefinedInt32Value { get; }
    }
}

