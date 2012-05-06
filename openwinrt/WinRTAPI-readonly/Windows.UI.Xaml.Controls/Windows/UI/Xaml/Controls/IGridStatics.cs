namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [ExclusiveTo(typeof(Grid)), WebHostHidden, Version(0x6020000), Windows.Foundation.Metadata.Guid(0x64fe2e9f, 0xf951, 0x42b6, 0xa9, 0xce, 0xbb, 0x17, 0x9a, 0xf1, 0x15, 0x95)]
    internal interface IGridStatics
    {
        int GetColumn([In] FrameworkElement element);
        int GetColumnSpan([In] FrameworkElement element);
        int GetRow([In] FrameworkElement element);
        int GetRowSpan([In] FrameworkElement element);
        void SetColumn([In] FrameworkElement element, [In] int value);
        void SetColumnSpan([In] FrameworkElement element, [In] int value);
        void SetRow([In] FrameworkElement element, [In] int value);
        void SetRowSpan([In] FrameworkElement element, [In] int value);

        DependencyProperty ColumnProperty { get; }

        DependencyProperty ColumnSpanProperty { get; }

        DependencyProperty RowProperty { get; }

        DependencyProperty RowSpanProperty { get; }
    }
}

