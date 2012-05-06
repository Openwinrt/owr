namespace Windows.UI.Xaml.Controls.Primitives
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Composable(typeof(IDragDeltaEventArgsFactory), CompositionType.Public, 0x6020000), Threading(ThreadingModel.Both), MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000), WebHostHidden]
    public class DragDeltaEventArgs : RoutedEventArgs, IDragDeltaEventArgs
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public DragDeltaEventArgs([In] double horizontalChange, [In] double verticalChange);

        public double HorizontalChange { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double VerticalChange { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Controls.Primitives.IDragDeltaEventArgs.HorizontalChange { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Controls.Primitives.IDragDeltaEventArgs.VerticalChange { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

