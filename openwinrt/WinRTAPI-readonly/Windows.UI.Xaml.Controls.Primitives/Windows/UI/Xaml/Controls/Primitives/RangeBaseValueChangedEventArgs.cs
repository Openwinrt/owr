namespace Windows.UI.Xaml.Controls.Primitives
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Version(0x6020000), Threading(ThreadingModel.Both), WebHostHidden, MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class RangeBaseValueChangedEventArgs : RoutedEventArgs, IRangeBaseValueChangedEventArgs
    {
        public double NewValue { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double OldValue { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Controls.Primitives.IRangeBaseValueChangedEventArgs.NewValue { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Controls.Primitives.IRangeBaseValueChangedEventArgs.OldValue { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

