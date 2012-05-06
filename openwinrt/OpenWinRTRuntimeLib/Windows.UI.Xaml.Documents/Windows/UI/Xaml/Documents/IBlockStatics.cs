namespace Windows.UI.Xaml.Documents
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Version(0x6020000), WebHostHidden, Guid(0xf86a8c34, 0x8d18, 0x4c53, 0xae, 0xbd, 0x91, 230, 0x10, 0xa5, 0xe0, 0x10), ExclusiveTo(typeof(Block))]
    internal interface IBlockStatics
    {
        DependencyProperty LineHeightProperty { get; }

        DependencyProperty LineStackingStrategyProperty { get; }

        DependencyProperty TextAlignmentProperty { get; }
    }
}

