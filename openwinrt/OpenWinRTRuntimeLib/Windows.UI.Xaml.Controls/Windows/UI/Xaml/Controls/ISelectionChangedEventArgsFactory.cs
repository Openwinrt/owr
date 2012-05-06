namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(SelectionChangedEventArgs)), Version(0x6020000), WebHostHidden, Windows.Foundation.Metadata.Guid(0x11a8b6b5, 0x2830, 0x4517, 0x84, 0xcd, 0x55, 0x24, 200, 0xb8, 0x8b, 0x45)]
    internal interface ISelectionChangedEventArgsFactory
    {
        SelectionChangedEventArgs CreateInstanceWithRemovedItemsAndAddedItems([In] IVector<object> removedItems, [In] IVector<object> addedItems, [In] object outer, out object inner);
    }
}

