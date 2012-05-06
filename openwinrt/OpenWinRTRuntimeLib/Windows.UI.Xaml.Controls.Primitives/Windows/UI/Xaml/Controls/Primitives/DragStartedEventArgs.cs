namespace Windows.UI.Xaml.Controls.Primitives
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Version(0x6020000), WebHostHidden, Threading(ThreadingModel.Both), Composable(typeof(IDragStartedEventArgsFactory), CompositionType.Public, 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public class DragStartedEventArgs : RoutedEventArgs, IDragStartedEventArgs
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public DragStartedEventArgs([In] double horizontalOffset, [In] double verticalOffset);

        public double HorizontalOffset { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double VerticalOffset { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Controls.Primitives.IDragStartedEventArgs.HorizontalOffset { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Controls.Primitives.IDragStartedEventArgs.VerticalOffset { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

