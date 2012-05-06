namespace Windows.UI.Xaml.Documents
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [ExclusiveTo(typeof(TextElement)), WebHostHidden, Guid(0xa2f9b98, 0x6c03, 0x4470, 0xa7, 0x9b, 50, 0x98, 0xa1, 4, 130, 0xce), Version(0x6020000)]
    internal interface ITextElementStatics
    {
        DependencyProperty CharacterSpacingProperty { get; }

        DependencyProperty FontFamilyProperty { get; }

        DependencyProperty FontSizeProperty { get; }

        DependencyProperty FontStretchProperty { get; }

        DependencyProperty FontStyleProperty { get; }

        DependencyProperty FontWeightProperty { get; }

        DependencyProperty ForegroundProperty { get; }

        DependencyProperty LanguageProperty { get; }
    }
}

