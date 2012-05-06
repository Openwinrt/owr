namespace Windows.UI.Xaml.Controls
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [ExclusiveTo(typeof(ToolTip)), Guid(0xf00285b8, 0x4ba9, 0x4f4f, 0x86, 0xa7, 0x86, 0, 0x38, 0x13, 0xce, 0xb3), Version(0x6020000), WebHostHidden]
    internal interface IToolTipStatics
    {
        DependencyProperty HorizontalOffsetProperty { get; }

        DependencyProperty IsOpenProperty { get; }

        DependencyProperty PlacementProperty { get; }

        DependencyProperty PlacementTargetProperty { get; }

        DependencyProperty VerticalOffsetProperty { get; }
    }
}

