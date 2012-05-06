namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [WebHostHidden, MarshalingBehavior(MarshalingType.FreeThreaded), Activatable(0x6020000), Version(0x6020000), Threading(ThreadingModel.Both), Static(typeof(IColumnDefinitionStatics), 0x6020000)]
    public sealed class ColumnDefinition : DependencyObject, IColumnDefinition
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ColumnDefinition();

        public double ActualWidth { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double MaxWidth { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty MaxWidthProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double MinWidth { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty MinWidthProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public GridLength Width { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty WidthProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Controls.IColumnDefinition.ActualWidth { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Controls.IColumnDefinition.MaxWidth { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public double Windows.UI.Xaml.Controls.IColumnDefinition.MinWidth { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public GridLength Windows.UI.Xaml.Controls.IColumnDefinition.Width { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

