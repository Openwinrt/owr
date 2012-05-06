namespace Windows.Globalization.Fonts
{
    using System;
    using Windows.Foundation.Metadata;
    using Windows.UI.Text;

    [ExclusiveTo(typeof(LanguageFont)), Guid(0xb12e5c3a, 0xb76d, 0x459b, 190, 0xeb, 0x90, 0x11, 0x51, 0xcd, 0x77, 0xd1), Version(0x6020000)]
    internal interface ILanguageFont
    {
        string FontFamily { get; }

        Windows.UI.Text.FontStretch FontStretch { get; }

        Windows.UI.Text.FontStyle FontStyle { get; }

        Windows.UI.Text.FontWeight FontWeight { get; }

        double ScaleFactor { get; }
    }
}

