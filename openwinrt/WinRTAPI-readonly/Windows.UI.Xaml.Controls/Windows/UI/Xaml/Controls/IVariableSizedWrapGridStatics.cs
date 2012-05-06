namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [WebHostHidden, Windows.Foundation.Metadata.Guid(0xfe9db859, 0x8127, 0x4aef, 0xb7, 0xa2, 0x94, 0x98, 0x47, 0x48, 110, 150), ExclusiveTo(typeof(VariableSizedWrapGrid)), Version(0x6020000)]
    internal interface IVariableSizedWrapGridStatics
    {
        int GetColumnSpan([In] UIElement element);
        int GetRowSpan([In] UIElement element);
        void SetColumnSpan([In] UIElement element, [In] int value);
        void SetRowSpan([In] UIElement element, [In] int value);

        DependencyProperty ColumnSpanProperty { get; }

        DependencyProperty HorizontalChildrenAlignmentProperty { get; }

        DependencyProperty ItemHeightProperty { get; }

        DependencyProperty ItemWidthProperty { get; }

        DependencyProperty MaximumRowsOrColumnsProperty { get; }

        DependencyProperty OrientationProperty { get; }

        DependencyProperty RowSpanProperty { get; }

        DependencyProperty VerticalChildrenAlignmentProperty { get; }
    }
}

