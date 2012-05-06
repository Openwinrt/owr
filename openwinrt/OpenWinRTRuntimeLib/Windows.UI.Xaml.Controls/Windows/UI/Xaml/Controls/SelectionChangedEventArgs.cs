namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000), Threading(ThreadingModel.Both), WebHostHidden, Composable(typeof(ISelectionChangedEventArgsFactory), CompositionType.Public, 0x6020000)]
    public class SelectionChangedEventArgs : RoutedEventArgs, ISelectionChangedEventArgs
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public SelectionChangedEventArgs([In] IVector<object> removedItems, [In] IVector<object> addedItems);

        public IVector<object> AddedItems { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVector<object> RemovedItems { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVector<object> Windows.UI.Xaml.Controls.ISelectionChangedEventArgs.AddedItems { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVector<object> Windows.UI.Xaml.Controls.ISelectionChangedEventArgs.RemovedItems { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

