namespace Windows.UI.Xaml.Media
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [WebHostHidden, Version(0x6020000), ExclusiveTo(typeof(TranslateTransform)), Guid(0xf419aa91, 0xe042, 0x4111, 0x9c, 0x2f, 210, 1, 0x30, 0x41, 0x23, 0xdd)]
    internal interface ITranslateTransformStatics
    {
        DependencyProperty XProperty { get; }

        DependencyProperty YProperty { get; }
    }
}

