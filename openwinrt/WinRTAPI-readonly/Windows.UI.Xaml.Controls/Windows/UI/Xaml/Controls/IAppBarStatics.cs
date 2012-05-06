namespace Windows.UI.Xaml.Controls
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [ExclusiveTo(typeof(AppBar)), Version(0x6020000), WebHostHidden, Guid(0x79bb7e8d, 0xdca9, 0x4b5f, 0xa4, 0x48, 0x37, 0xb1, 50, 0x38, 0xed, 0x76)]
    internal interface IAppBarStatics
    {
        DependencyProperty IsOpenProperty { get; }

        DependencyProperty IsStickyProperty { get; }
    }
}

