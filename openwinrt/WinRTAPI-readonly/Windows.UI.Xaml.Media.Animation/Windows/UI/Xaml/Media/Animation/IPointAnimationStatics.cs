namespace Windows.UI.Xaml.Media.Animation
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Guid(0x2f99b356, 0xe737, 0x408b, 160, 0xfd, 50, 120, 0x26, 0xd3, 0x22, 0x55), ExclusiveTo(typeof(PointAnimation)), Version(0x6020000), WebHostHidden]
    internal interface IPointAnimationStatics
    {
        DependencyProperty ByProperty { get; }

        DependencyProperty EasingFunctionProperty { get; }

        DependencyProperty EnableDependentAnimationProperty { get; }

        DependencyProperty FromProperty { get; }

        DependencyProperty ToProperty { get; }
    }
}

