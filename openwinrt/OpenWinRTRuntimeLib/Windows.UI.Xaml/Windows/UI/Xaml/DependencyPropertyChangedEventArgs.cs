namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Threading(ThreadingModel.Both), Version(0x6020000), WebHostHidden, MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class DependencyPropertyChangedEventArgs : IDependencyPropertyChangedEventArgs
    {
        public object NewValue { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public object OldValue { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public DependencyProperty Property { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public object Windows.UI.Xaml.IDependencyPropertyChangedEventArgs.NewValue { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public object Windows.UI.Xaml.IDependencyPropertyChangedEventArgs.OldValue { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public DependencyProperty Windows.UI.Xaml.IDependencyPropertyChangedEventArgs.Property { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

