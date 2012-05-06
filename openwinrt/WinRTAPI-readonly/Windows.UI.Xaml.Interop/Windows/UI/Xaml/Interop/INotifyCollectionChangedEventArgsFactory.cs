namespace Windows.UI.Xaml.Interop
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Windows.Foundation.Metadata.Guid(0xb30c3e3a, 0xdf8d, 0x44a5, 0x9a, 0x38, 0x7a, 0xc0, 0xd0, 140, 230, 0x3d), ExclusiveTo(typeof(NotifyCollectionChangedEventArgs)), Version(0x6020000)]
    internal interface INotifyCollectionChangedEventArgsFactory
    {
        NotifyCollectionChangedEventArgs CreateInstanceWithAllParameters([In] NotifyCollectionChangedAction action, [In] IBindableVector newItems, [In] IBindableVector oldItems, [In] int newIndex, [In] int oldIndex, [In] object outer, out object inner);
    }
}

