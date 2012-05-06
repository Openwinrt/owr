namespace Windows.Globalization.Fonts
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [DualApiPartition(version=0x6020000), Activatable(typeof(ILanguageFontGroupFactory), 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000), Threading(ThreadingModel.MTA)]
    public sealed class LanguageFontGroup : ILanguageFontGroup
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public LanguageFontGroup([In] string languageTag);

        public LanguageFont DocumentAlternate1Font { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public LanguageFont DocumentAlternate2Font { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public LanguageFont DocumentHeadingFont { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public LanguageFont FixedWidthTextFont { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public LanguageFont ModernDocumentFont { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public LanguageFont TraditionalDocumentFont { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public LanguageFont UICaptionsFont { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public LanguageFont UIHeadingFont { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public LanguageFont UINotificationsFont { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public LanguageFont UITextFont { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public LanguageFont UITitleFont { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public LanguageFont Windows.Globalization.Fonts.ILanguageFontGroup.DocumentAlternate1Font { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public LanguageFont Windows.Globalization.Fonts.ILanguageFontGroup.DocumentAlternate2Font { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public LanguageFont Windows.Globalization.Fonts.ILanguageFontGroup.DocumentHeadingFont { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public LanguageFont Windows.Globalization.Fonts.ILanguageFontGroup.FixedWidthTextFont { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public LanguageFont Windows.Globalization.Fonts.ILanguageFontGroup.ModernDocumentFont { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public LanguageFont Windows.Globalization.Fonts.ILanguageFontGroup.TraditionalDocumentFont { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public LanguageFont Windows.Globalization.Fonts.ILanguageFontGroup.UICaptionsFont { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public LanguageFont Windows.Globalization.Fonts.ILanguageFontGroup.UIHeadingFont { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public LanguageFont Windows.Globalization.Fonts.ILanguageFontGroup.UINotificationsFont { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public LanguageFont Windows.Globalization.Fonts.ILanguageFontGroup.UITextFont { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public LanguageFont Windows.Globalization.Fonts.ILanguageFontGroup.UITitleFont { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

