namespace Windows.UI.Xaml.Controls
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [ExclusiveTo(typeof(TextBox)), WebHostHidden, Guid(0x7e37f4fb, 0xa4bc, 0x4625, 0x88, 0x38, 0x8e, 0xb2, 0xa9, 9, 0x12, 0x83), Version(0x6020000)]
    internal interface ITextBoxStatics
    {
        DependencyProperty AcceptsReturnProperty { get; }

        DependencyProperty InputScopeProperty { get; }

        DependencyProperty IsReadOnlyProperty { get; }

        DependencyProperty IsSpellCheckEnabledProperty { get; }

        DependencyProperty IsTextPredictionEnabledProperty { get; }

        DependencyProperty MaxLengthProperty { get; }

        DependencyProperty TextAlignmentProperty { get; }

        DependencyProperty TextProperty { get; }

        DependencyProperty TextWrappingProperty { get; }
    }
}

