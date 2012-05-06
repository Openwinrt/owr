namespace Windows.UI.Xaml.Media.Animation
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Version(0x6020000), ExclusiveTo(typeof(DoubleAnimation)), Guid(0xe27a935d, 0xf111, 0x43b7, 0xb8, 0x24, 0x83, 0x2b, 0x58, 0xd7, 120, 0x6b), WebHostHidden]
    internal interface IDoubleAnimationStatics
    {
        DependencyProperty ByProperty { get; }

        DependencyProperty EasingFunctionProperty { get; }

        DependencyProperty EnableDependentAnimationProperty { get; }

        DependencyProperty FromProperty { get; }

        DependencyProperty ToProperty { get; }
    }
}

