namespace Windows.Globalization.Fonts
{
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(LanguageFontGroup)), Guid(0xf33a7fc3, 0x3a5c, 0x4aea, 0xb9, 0xff, 0xb3, 0x9f, 0xb2, 0x42, 0xf7, 0xf6)]
    internal interface ILanguageFontGroup
    {
        LanguageFont DocumentAlternate1Font { get; }

        LanguageFont DocumentAlternate2Font { get; }

        LanguageFont DocumentHeadingFont { get; }

        LanguageFont FixedWidthTextFont { get; }

        LanguageFont ModernDocumentFont { get; }

        LanguageFont TraditionalDocumentFont { get; }

        LanguageFont UICaptionsFont { get; }

        LanguageFont UIHeadingFont { get; }

        LanguageFont UINotificationsFont { get; }

        LanguageFont UITextFont { get; }

        LanguageFont UITitleFont { get; }
    }
}

