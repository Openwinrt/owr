namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both), Static(typeof(IGridStatics), 0x6020000), WebHostHidden, Version(0x6020000), Composable(typeof(IGridFactory), CompositionType.Public, 0x6020000)]
    public class Grid : Panel, IGrid
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Grid();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static int GetColumn([In] FrameworkElement element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static int GetColumnSpan([In] FrameworkElement element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static int GetRow([In] FrameworkElement element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static int GetRowSpan([In] FrameworkElement element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetColumn([In] FrameworkElement element, [In] int value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetColumnSpan([In] FrameworkElement element, [In] int value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetRow([In] FrameworkElement element, [In] int value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetRowSpan([In] FrameworkElement element, [In] int value);

        public ColumnDefinitionCollection ColumnDefinitions { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty ColumnProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty ColumnSpanProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public RowDefinitionCollection RowDefinitions { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty RowProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty RowSpanProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ColumnDefinitionCollection Windows.UI.Xaml.Controls.IGrid.ColumnDefinitions { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public RowDefinitionCollection Windows.UI.Xaml.Controls.IGrid.RowDefinitions { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

