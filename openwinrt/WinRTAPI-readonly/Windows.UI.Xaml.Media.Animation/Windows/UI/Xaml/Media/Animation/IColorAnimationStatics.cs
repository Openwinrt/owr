namespace Windows.UI.Xaml.Media.Animation
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [ExclusiveTo(typeof(ColorAnimation)), Guid(0x55eaf6e2, 0x87e3, 0x4f48, 0x95, 0x8f, 0x85, 0x5b, 0x2f, 0x9e, 0xa9, 0xec), Version(0x6020000), WebHostHidden]
    internal interface IColorAnimationStatics
    {
        DependencyProperty ByProperty { get; }

        DependencyProperty EasingFunctionProperty { get; }

        DependencyProperty EnableDependentAnimationProperty { get; }

        DependencyProperty FromProperty { get; }

        DependencyProperty ToProperty { get; }
    }
}

