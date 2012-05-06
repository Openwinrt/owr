namespace Windows.UI.Xaml.Controls
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [ExclusiveTo(typeof(RichEditBox)), Guid(0xf5e03a74, 0x88ea, 0x479b, 0x9a, 5, 0x37, 8, 0x9f, 0xf3, 14, 0xde), Version(0x6020000), WebHostHidden]
    internal interface IRichEditBoxStatics
    {
        DependencyProperty AcceptsReturnProperty { get; }

        DependencyProperty InputScopeProperty { get; }

        DependencyProperty IsReadOnlyProperty { get; }

        DependencyProperty IsSpellCheckEnabledProperty { get; }

        DependencyProperty IsTextPredictionEnabledProperty { get; }

        DependencyProperty TextAlignmentProperty { get; }

        DependencyProperty TextWrappingProperty { get; }
    }
}

