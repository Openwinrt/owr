namespace Windows.UI.Xaml.Controls
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls.Primitives;

    [Guid(0x7d9901f1, 0xe7c1, 0x4e83, 180, 0x70, 0xc9, 0xd6, 0xd7, 0xbd, 0xa9, 0xf5), WebHostHidden, ExclusiveTo(typeof(GridViewItem)), Version(0x6020000)]
    internal interface IGridViewItem
    {
        GridViewItemTemplateSettings TemplateSettings { get; }
    }
}

