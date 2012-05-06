namespace Windows.UI.Xaml.Media.Animation
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Version(0x6020000), WebHostHidden, Guid(0xa9f566ec, 0xfe9c, 0x4b2b, 0x8e, 0x52, 0xbb, 120, 0x5d, 0x56, 0x21, 0x85), ExclusiveTo(typeof(ElasticEase))]
    internal interface IElasticEaseStatics
    {
        DependencyProperty OscillationsProperty { get; }

        DependencyProperty SpringinessProperty { get; }
    }
}

