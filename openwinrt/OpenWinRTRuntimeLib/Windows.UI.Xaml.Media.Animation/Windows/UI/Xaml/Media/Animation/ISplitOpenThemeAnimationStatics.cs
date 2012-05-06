namespace Windows.UI.Xaml.Media.Animation
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Guid(0x8d4cfa89, 0x3a91, 0x458d, 0xb0, 0xfb, 0x4c, 0xad, 0x62, 0x5c, 0xbf, 0x8d), ExclusiveTo(typeof(SplitOpenThemeAnimation)), WebHostHidden, Version(0x6020000)]
    internal interface ISplitOpenThemeAnimationStatics
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

