namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Version(0x6020000), WebHostHidden, Threading(ThreadingModel.Both), Static(typeof(IRowDefinitionStatics), 0x6020000), Activatable(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class RowDefinition : DependencyObject, IRowDefinition
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public RowDefinition();

        public double ActualHeight { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public GridLength Height { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty HeightProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double MaxHeight { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty MaxHeightProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double MinHeight { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty MinHeightProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Controls.IRowDefinition.ActualHeight { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public GridLength Windows.UI.Xaml.Controls.IRowDefinition.Height { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public double Windows.UI.Xaml.Controls.IRowDefinition.MaxHeight { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public double Windows.UI.Xaml.Controls.IRowDefinition.MinHeight { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

