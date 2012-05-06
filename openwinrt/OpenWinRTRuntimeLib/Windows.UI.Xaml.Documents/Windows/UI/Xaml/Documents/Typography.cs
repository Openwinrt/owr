namespace Windows.UI.Xaml.Documents
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000), WebHostHidden, Threading(ThreadingModel.Both), Static(typeof(ITypographyStatics), 0x6020000)]
    public sealed class Typography : ITypography
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static int GetAnnotationAlternates([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static FontCapitals GetCapitals([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool GetCapitalSpacing([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool GetCaseSensitiveForms([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool GetContextualAlternates([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool GetContextualLigatures([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static int GetContextualSwashes([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool GetDiscretionaryLigatures([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool GetEastAsianExpertForms([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static FontEastAsianLanguage GetEastAsianLanguage([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static FontEastAsianWidths GetEastAsianWidths([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static FontFraction GetFraction([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool GetHistoricalForms([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool GetHistoricalLigatures([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool GetKerning([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool GetMathematicalGreek([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static FontNumeralAlignment GetNumeralAlignment([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static FontNumeralStyle GetNumeralStyle([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool GetSlashedZero([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool GetStandardLigatures([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static int GetStandardSwashes([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static int GetStylisticAlternates([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool GetStylisticSet1([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool GetStylisticSet10([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool GetStylisticSet11([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool GetStylisticSet12([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool GetStylisticSet13([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool GetStylisticSet14([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool GetStylisticSet15([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool GetStylisticSet16([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool GetStylisticSet17([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool GetStylisticSet18([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool GetStylisticSet19([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool GetStylisticSet2([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool GetStylisticSet20([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool GetStylisticSet3([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool GetStylisticSet4([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool GetStylisticSet5([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool GetStylisticSet6([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool GetStylisticSet7([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool GetStylisticSet8([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool GetStylisticSet9([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static FontVariants GetVariants([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetAnnotationAlternates([In] DependencyObject element, [In] int value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetCapitals([In] DependencyObject element, [In] FontCapitals value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetCapitalSpacing([In] DependencyObject element, [In] bool value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetCaseSensitiveForms([In] DependencyObject element, [In] bool value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetContextualAlternates([In] DependencyObject element, [In] bool value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetContextualLigatures([In] DependencyObject element, [In] bool value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetContextualSwashes([In] DependencyObject element, [In] int value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetDiscretionaryLigatures([In] DependencyObject element, [In] bool value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetEastAsianExpertForms([In] DependencyObject element, [In] bool value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetEastAsianLanguage([In] DependencyObject element, [In] FontEastAsianLanguage value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetEastAsianWidths([In] DependencyObject element, [In] FontEastAsianWidths value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetFraction([In] DependencyObject element, [In] FontFraction value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetHistoricalForms([In] DependencyObject element, [In] bool value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetHistoricalLigatures([In] DependencyObject element, [In] bool value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetKerning([In] DependencyObject element, [In] bool value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetMathematicalGreek([In] DependencyObject element, [In] bool value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetNumeralAlignment([In] DependencyObject element, [In] FontNumeralAlignment value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetNumeralStyle([In] DependencyObject element, [In] FontNumeralStyle value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetSlashedZero([In] DependencyObject element, [In] bool value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetStandardLigatures([In] DependencyObject element, [In] bool value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetStandardSwashes([In] DependencyObject element, [In] int value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetStylisticAlternates([In] DependencyObject element, [In] int value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetStylisticSet1([In] DependencyObject element, [In] bool value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetStylisticSet10([In] DependencyObject element, [In] bool value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetStylisticSet11([In] DependencyObject element, [In] bool value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetStylisticSet12([In] DependencyObject element, [In] bool value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetStylisticSet13([In] DependencyObject element, [In] bool value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetStylisticSet14([In] DependencyObject element, [In] bool value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetStylisticSet15([In] DependencyObject element, [In] bool value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetStylisticSet16([In] DependencyObject element, [In] bool value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetStylisticSet17([In] DependencyObject element, [In] bool value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetStylisticSet18([In] DependencyObject element, [In] bool value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetStylisticSet19([In] DependencyObject element, [In] bool value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetStylisticSet2([In] DependencyObject element, [In] bool value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetStylisticSet20([In] DependencyObject element, [In] bool value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetStylisticSet3([In] DependencyObject element, [In] bool value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetStylisticSet4([In] DependencyObject element, [In] bool value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetStylisticSet5([In] DependencyObject element, [In] bool value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetStylisticSet6([In] DependencyObject element, [In] bool value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetStylisticSet7([In] DependencyObject element, [In] bool value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetStylisticSet8([In] DependencyObject element, [In] bool value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetStylisticSet9([In] DependencyObject element, [In] bool value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetVariants([In] DependencyObject element, [In] FontVariants value);

        public static DependencyProperty AnnotationAlternatesProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty CapitalSpacingProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty CapitalsProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty CaseSensitiveFormsProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty ContextualAlternatesProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty ContextualLigaturesProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty ContextualSwashesProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty DiscretionaryLigaturesProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty EastAsianExpertFormsProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty EastAsianLanguageProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty EastAsianWidthsProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty FractionProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty HistoricalFormsProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty HistoricalLigaturesProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty KerningProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty MathematicalGreekProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty NumeralAlignmentProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty NumeralStyleProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty SlashedZeroProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty StandardLigaturesProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty StandardSwashesProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty StylisticAlternatesProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty StylisticSet10Property { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty StylisticSet11Property { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty StylisticSet12Property { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty StylisticSet13Property { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty StylisticSet14Property { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty StylisticSet15Property { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty StylisticSet16Property { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty StylisticSet17Property { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty StylisticSet18Property { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty StylisticSet19Property { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty StylisticSet1Property { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty StylisticSet20Property { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty StylisticSet2Property { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty StylisticSet3Property { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty StylisticSet4Property { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty StylisticSet5Property { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty StylisticSet6Property { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty StylisticSet7Property { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty StylisticSet8Property { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty StylisticSet9Property { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty VariantsProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

