namespace Windows.UI.Xaml.Controls.Primitives
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000), Composable(typeof(IDragCompletedEventArgsFactory), CompositionType.Public, 0x6020000), Threading(ThreadingModel.Both), WebHostHidden]
    public class DragCompletedEventArgs : RoutedEventArgs, IDragCompletedEventArgs
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public DragCompletedEventArgs([In] double horizontalChange, [In] double verticalChange, [In] bool canceled);

        public bool Canceled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double HorizontalChange { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double VerticalChange { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Xaml.Controls.Primitives.IDragCompletedEventArgs.Canceled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Controls.Primitives.IDragCompletedEventArgs.HorizontalChange { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Controls.Primitives.IDragCompletedEventArgs.VerticalChange { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

