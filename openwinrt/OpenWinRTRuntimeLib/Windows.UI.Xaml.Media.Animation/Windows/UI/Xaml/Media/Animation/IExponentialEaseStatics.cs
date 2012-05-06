namespace Windows.UI.Xaml.Media.Animation
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Guid(0xf37ee7e3, 0xa761, 0x4352, 0x9a, 0xd6, 0x70, 0x79, 0x45, 0x67, 0x58, 0x1a), WebHostHidden, Version(0x6020000), ExclusiveTo(typeof(ExponentialEase))]
    internal interface IExponentialEaseStatics
    {
        DependencyProperty ExponentProperty { get; }
    }
}

