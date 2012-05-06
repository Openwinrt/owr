namespace Windows.UI.Xaml.Controls
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [ExclusiveTo(typeof(WrapGrid)), Version(0x6020000), WebHostHidden, Guid(0xd04a6b97, 0x13cb, 0x479c, 0xa2, 0x85, 0xe4, 0xe5, 0x68, 70, 0xc4, 0xcb)]
    internal interface IWrapGridStatics
    {
        DependencyProperty HorizontalChildrenAlignmentProperty { get; }

        DependencyProperty ItemHeightProperty { get; }

        DependencyProperty ItemWidthProperty { get; }

        DependencyProperty MaximumRowsOrColumnsProperty { get; }

        DependencyProperty OrientationProperty { get; }

        DependencyProperty VerticalChildrenAlignmentProperty { get; }
    }
}

