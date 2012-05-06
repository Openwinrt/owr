namespace Windows.UI.Xaml.Controls
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Version(0x6020000), Guid(0xe8887976, 0x2c5c, 0x41cf, 190, 0x6a, 0x9e, 0x44, 190, 0xfd, 0xf6, 0x55), WebHostHidden, ExclusiveTo(typeof(UserControl))]
    internal interface IUserControlStatics
    {
        DependencyProperty ContentProperty { get; }
    }
}

