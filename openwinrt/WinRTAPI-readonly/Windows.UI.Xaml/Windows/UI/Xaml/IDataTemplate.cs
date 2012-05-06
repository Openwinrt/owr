namespace Windows.UI.Xaml
{
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(DataTemplate)), WebHostHidden, Guid(0x9910aec7, 0x8ab5, 0x4118, 0x9b, 0xc6, 9, 0xf4, 90, 0x35, 7, 0x3d), Version(0x6020000)]
    internal interface IDataTemplate
    {
        DependencyObject LoadContent();
    }
}

