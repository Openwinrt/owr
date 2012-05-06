namespace Windows.UI.Xaml.Media.Animation
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [WebHostHidden, ExclusiveTo(typeof(SplitCloseThemeAnimation)), Guid(0x7aa94de9, 0xcc9b, 0x4e90, 0xa1, 0x1a, 0, 80, 0xa2, 0x21, 0x6a, 0x9e), Version(0x6020000)]
    internal interface ISplitCloseThemeAnimationStatics
    {
        DependencyProperty ClosedLengthProperty { get; }

        DependencyProperty ClosedTargetNameProperty { get; }

        DependencyProperty ContentTargetNameProperty { get; }

        DependencyProperty ContentTranslationDirectionProperty { get; }

        DependencyProperty ContentTranslationOffsetProperty { get; }

        DependencyProperty OffsetFromCenterProperty { get; }

        DependencyProperty OpenedLengthProperty { get; }

        DependencyProperty OpenedTargetNameProperty { get; }
    }
}

