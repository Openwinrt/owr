namespace Windows.UI.Xaml.Interop
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000), WebHostHidden, Composable(typeof(INotifyCollectionChangedEventArgsFactory), CompositionType.Public, 0x6020000), Threading(ThreadingModel.Both)]
    public class NotifyCollectionChangedEventArgs : INotifyCollectionChangedEventArgs
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public NotifyCollectionChangedEventArgs([In] NotifyCollectionChangedAction action, [In] IBindableVector newItems, [In] IBindableVector oldItems, [In] int newIndex, [In] int oldIndex);

        public NotifyCollectionChangedAction Action { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IBindableVector NewItems { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int NewStartingIndex { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IBindableVector OldItems { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int OldStartingIndex { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public NotifyCollectionChangedAction Windows.UI.Xaml.Interop.INotifyCollectionChangedEventArgs.Action { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IBindableVector Windows.UI.Xaml.Interop.INotifyCollectionChangedEventArgs.NewItems { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int Windows.UI.Xaml.Interop.INotifyCollectionChangedEventArgs.NewStartingIndex { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IBindableVector Windows.UI.Xaml.Interop.INotifyCollectionChangedEventArgs.OldItems { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int Windows.UI.Xaml.Interop.INotifyCollectionChangedEventArgs.OldStartingIndex { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

