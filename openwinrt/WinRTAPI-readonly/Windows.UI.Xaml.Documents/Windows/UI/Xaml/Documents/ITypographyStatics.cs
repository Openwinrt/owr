namespace Windows.UI.Xaml.Documents
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [ExclusiveTo(typeof(Typography)), Windows.Foundation.Metadata.Guid(0x67b9ec88, 0x6c57, 0x4ce0, 0x95, 0xf1, 0xd4, 0xb9, 0xed, 0x63, 0x2f, 180), Version(0x6020000), WebHostHidden]
    internal interface ITypographyStatics
    {
        int GetAnnotationAlternates([In] DependencyObject element);
        FontCapitals GetCapitals([In] DependencyObject element);
        bool GetCapitalSpacing([In] DependencyObject element);
        bool GetCaseSensitiveForms([In] DependencyObject element);
        bool GetContextualAlternates([In] DependencyObject element);
        bool GetContextualLigatures([In] DependencyObject element);
        int GetContextualSwashes([In] DependencyObject element);
        bool GetDiscretionaryLigatures([In] DependencyObject element);
        bool GetEastAsianExpertForms([In] DependencyObject element);
        FontEastAsianLanguage GetEastAsianLanguage([In] DependencyObject element);
        FontEastAsianWidths GetEastAsianWidths([In] DependencyObject element);
        FontFraction GetFraction([In] DependencyObject element);
        bool GetHistoricalForms([In] DependencyObject element);
        bool GetHistoricalLigatures([In] DependencyObject element);
        bool GetKerning([In] DependencyObject element);
        bool GetMathematicalGreek([In] DependencyObject element);
        FontNumeralAlignment GetNumeralAlignment([In] DependencyObject element);
        FontNumeralStyle GetNumeralStyle([In] DependencyObject element);
        bool GetSlashedZero([In] DependencyObject element);
        bool GetStandardLigatures([In] DependencyObject element);
        int GetStandardSwashes([In] DependencyObject element);
        int GetStylisticAlternates([In] DependencyObject element);
        bool GetStylisticSet1([In] DependencyObject element);
        bool GetStylisticSet10([In] DependencyObject element);
        bool GetStylisticSet11([In] DependencyObject element);
        bool GetStylisticSet12([In] DependencyObject element);
        bool GetStylisticSet13([In] DependencyObject element);
        bool GetStylisticSet14([In] DependencyObject element);
        bool GetStylisticSet15([In] DependencyObject element);
        bool GetStylisticSet16([In] DependencyObject element);
        bool GetStylisticSet17([In] DependencyObject element);
        bool GetStylisticSet18([In] DependencyObject element);
        bool GetStylisticSet19([In] DependencyObject element);
        bool GetStylisticSet2([In] DependencyObject element);
        bool GetStylisticSet20([In] DependencyObject element);
        bool GetStylisticSet3([In] DependencyObject element);
        bool GetStylisticSet4([In] DependencyObject element);
        bool GetStylisticSet5([In] DependencyObject element);
        bool GetStylisticSet6([In] DependencyObject element);
        bool GetStylisticSet7([In] DependencyObject element);
        bool GetStylisticSet8([In] DependencyObject element);
        bool GetStylisticSet9([In] DependencyObject element);
        FontVariants GetVariants([In] DependencyObject element);
        void SetAnnotationAlternates([In] DependencyObject element, [In] int value);
        void SetCapitals([In] DependencyObject element, [In] FontCapitals value);
        void SetCapitalSpacing([In] DependencyObject element, [In] bool value);
        void SetCaseSensitiveForms([In] DependencyObject element, [In] bool value);
        void SetContextualAlternates([In] DependencyObject element, [In] bool value);
        void SetContextualLigatures([In] DependencyObject element, [In] bool value);
        void SetContextualSwashes([In] DependencyObject element, [In] int value);
        void SetDiscretionaryLigatures([In] DependencyObject element, [In] bool value);
        void SetEastAsianExpertForms([In] DependencyObject element, [In] bool value);
        void SetEastAsianLanguage([In] DependencyObject element, [In] FontEastAsianLanguage value);
        void SetEastAsianWidths([In] DependencyObject element, [In] FontEastAsianWidths value);
        void SetFraction([In] DependencyObject element, [In] FontFraction value);
        void SetHistoricalForms([In] DependencyObject element, [In] bool value);
        void SetHistoricalLigatures([In] DependencyObject element, [In] bool value);
        void SetKerning([In] DependencyObject element, [In] bool value);
        void SetMathematicalGreek([In] DependencyObject element, [In] bool value);
        void SetNumeralAlignment([In] DependencyObject element, [In] FontNumeralAlignment value);
        void SetNumeralStyle([In] DependencyObject element, [In] FontNumeralStyle value);
        void SetSlashedZero([In] DependencyObject element, [In] bool value);
        void SetStandardLigatures([In] DependencyObject element, [In] bool value);
        void SetStandardSwashes([In] DependencyObject element, [In] int value);
        void SetStylisticAlternates([In] DependencyObject element, [In] int value);
        void SetStylisticSet1([In] DependencyObject element, [In] bool value);
        void SetStylisticSet10([In] DependencyObject element, [In] bool value);
        void SetStylisticSet11([In] DependencyObject element, [In] bool value);
        void SetStylisticSet12([In] DependencyObject element, [In] bool value);
        void SetStylisticSet13([In] DependencyObject element, [In] bool value);
        void SetStylisticSet14([In] DependencyObject element, [In] bool value);
        void SetStylisticSet15([In] DependencyObject element, [In] bool value);
        void SetStylisticSet16([In] DependencyObject element, [In] bool value);
        void SetStylisticSet17([In] DependencyObject element, [In] bool value);
        void SetStylisticSet18([In] DependencyObject element, [In] bool value);
        void SetStylisticSet19([In] DependencyObject element, [In] bool value);
        void SetStylisticSet2([In] DependencyObject element, [In] bool value);
        void SetStylisticSet20([In] DependencyObject element, [In] bool value);
        void SetStylisticSet3([In] DependencyObject element, [In] bool value);
        void SetStylisticSet4([In] DependencyObject element, [In] bool value);
        void SetStylisticSet5([In] DependencyObject element, [In] bool value);
        void SetStylisticSet6([In] DependencyObject element, [In] bool value);
        void SetStylisticSet7([In] DependencyObject element, [In] bool value);
        void SetStylisticSet8([In] DependencyObject element, [In] bool value);
        void SetStylisticSet9([In] DependencyObject element, [In] bool value);
        void SetVariants([In] DependencyObject element, [In] FontVariants value);

        DependencyProperty AnnotationAlternatesProperty { get; }

        DependencyProperty CapitalSpacingProperty { get; }

        DependencyProperty CapitalsProperty { get; }

        DependencyProperty CaseSensitiveFormsProperty { get; }

        DependencyProperty ContextualAlternatesProperty { get; }

        DependencyProperty ContextualLigaturesProperty { get; }

        DependencyProperty ContextualSwashesProperty { get; }

        DependencyProperty DiscretionaryLigaturesProperty { get; }

        DependencyProperty EastAsianExpertFormsProperty { get; }

        DependencyProperty EastAsianLanguageProperty { get; }

        DependencyProperty EastAsianWidthsProperty { get; }

        DependencyProperty FractionProperty { get; }

        DependencyProperty HistoricalFormsProperty { get; }

        DependencyProperty HistoricalLigaturesProperty { get; }

        DependencyProperty KerningProperty { get; }

        DependencyProperty MathematicalGreekProperty { get; }

        DependencyProperty NumeralAlignmentProperty { get; }

        DependencyProperty NumeralStyleProperty { get; }

        DependencyProperty SlashedZeroProperty { get; }

        DependencyProperty StandardLigaturesProperty { get; }

        DependencyProperty StandardSwashesProperty { get; }

        DependencyProperty StylisticAlternatesProperty { get; }

        DependencyProperty StylisticSet10Property { get; }

        DependencyProperty StylisticSet11Property { get; }

        DependencyProperty StylisticSet12Property { get; }

        DependencyProperty StylisticSet13Property { get; }

        DependencyProperty StylisticSet14Property { get; }

        DependencyProperty StylisticSet15Property { get; }

        DependencyProperty StylisticSet16Property { get; }

        DependencyProperty StylisticSet17Property { get; }

        DependencyProperty StylisticSet18Property { get; }

        DependencyProperty StylisticSet19Property { get; }

        DependencyProperty StylisticSet1Property { get; }

        DependencyProperty StylisticSet20Property { get; }

        DependencyProperty StylisticSet2Property { get; }

        DependencyProperty StylisticSet3Property { get; }

        DependencyProperty StylisticSet4Property { get; }

        DependencyProperty StylisticSet5Property { get; }

        DependencyProperty StylisticSet6Property { get; }

        DependencyProperty StylisticSet7Property { get; }

        DependencyProperty StylisticSet8Property { get; }

        DependencyProperty StylisticSet9Property { get; }

        DependencyProperty VariantsProperty { get; }
    }
}

