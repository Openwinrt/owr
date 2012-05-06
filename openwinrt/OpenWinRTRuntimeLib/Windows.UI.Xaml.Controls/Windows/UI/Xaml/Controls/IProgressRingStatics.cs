namespace Windows.UI.Xaml.Controls
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [ExclusiveTo(typeof(ProgressRing)), Guid(0xe8b62507, 0x4e2c, 0x47d5, 0xa5, 0x4a, 0xc6, 0xc4, 0x8a, 0x5e, 0x69, 0x89), Version(0x6020000), WebHostHidden]
    internal interface IProgressRingStatics
    {
        DependencyProperty IsActiveProperty { get; }
    }
}

