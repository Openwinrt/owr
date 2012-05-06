namespace Windows.UI.Xaml.Controls.Primitives
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [MarshalingBehavior(MarshalingType.FreeThreaded), WebHostHidden, Activatable(0x6020000), Threading(ThreadingModel.Both), Version(0x6020000)]
    public sealed class ScrollEventArgs : RoutedEventArgs, IScrollEventArgs
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ScrollEventArgs();

        public double NewValue { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Controls.Primitives.ScrollEventType ScrollEventType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Controls.Primitives.IScrollEventArgs.NewValue { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Controls.Primitives.ScrollEventType Windows.UI.Xaml.Controls.Primitives.IScrollEventArgs.ScrollEventType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

