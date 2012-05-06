namespace Windows.UI.Xaml.Controls
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [WebHostHidden, Version(0x6020000), ExclusiveTo(typeof(ListBox)), Guid(0x6d3f7f73, 0x706a, 0x4e53, 0xa9, 170, 0xc9, 0xa5, 60, 0x9c, 0xdd, 0x70)]
    internal interface IListBoxStatics
    {
        DependencyProperty SelectionModeProperty { get; }
    }
}

