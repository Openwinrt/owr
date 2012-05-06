namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [MarshalingBehavior(MarshalingType.FreeThreaded), WebHostHidden, Threading(ThreadingModel.Both), Static(typeof(IVariableSizedWrapGridStatics), 0x6020000), Version(0x6020000), Activatable(0x6020000)]
    public sealed class VariableSizedWrapGrid : Panel, IVariableSizedWrapGrid
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public VariableSizedWrapGrid();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static int GetColumnSpan([In] UIElement element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static int GetRowSpan([In] UIElement element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetColumnSpan([In] UIElement element, [In] int value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetRowSpan([In] UIElement element, [In] int value);

        public static DependencyProperty ColumnSpanProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public HorizontalAlignment HorizontalChildrenAlignment { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty HorizontalChildrenAlignmentProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double ItemHeight { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty ItemHeightProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double ItemWidth { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty ItemWidthProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int MaximumRowsOrColumns { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty MaximumRowsOrColumnsProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Controls.Orientation Orientation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty OrientationProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty RowSpanProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public VerticalAlignment VerticalChildrenAlignment { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty VerticalChildrenAlignmentProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public HorizontalAlignment Windows.UI.Xaml.Controls.IVariableSizedWrapGrid.HorizontalChildrenAlignment { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public double Windows.UI.Xaml.Controls.IVariableSizedWrapGrid.ItemHeight { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public double Windows.UI.Xaml.Controls.IVariableSizedWrapGrid.ItemWidth { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public int Windows.UI.Xaml.Controls.IVariableSizedWrapGrid.MaximumRowsOrColumns { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.UI.Xaml.Controls.Orientation Windows.UI.Xaml.Controls.IVariableSizedWrapGrid.Orientation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public VerticalAlignment Windows.UI.Xaml.Controls.IVariableSizedWrapGrid.VerticalChildrenAlignment { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

