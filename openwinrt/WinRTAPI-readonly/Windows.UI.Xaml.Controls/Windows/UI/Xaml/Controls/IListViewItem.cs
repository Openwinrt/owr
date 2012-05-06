namespace Windows.UI.Xaml.Controls
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls.Primitives;

    [WebHostHidden, Version(0x6020000), ExclusiveTo(typeof(ListViewItem)), Guid(0xb7bb4305, 0x3dd9, 0x43de, 0xa8, 0xc0, 0xc4, 0x72, 240, 0x85, 0xbc, 0x11)]
    internal interface IListViewItem
    {
        ListViewItemTemplateSettings TemplateSettings { get; }
    }
}

