namespace Windows.UI.Xaml.Controls
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls.Primitives;

    [WebHostHidden, Guid(0x38aad50c, 0x12cf, 0x4d1e, 0xa8, 0x84, 0xc9, 0xdf, 0x85, 240, 0x7c, 0xd9), ExclusiveTo(typeof(VirtualizingPanel)), Version(0x6020000)]
    internal interface IVirtualizingPanel
    {
        Windows.UI.Xaml.Controls.Primitives.IItemContainerGenerator ItemContainerGenerator { get; }
    }
}

