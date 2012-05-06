namespace Windows.UI.Xaml.Data
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x8be8bfe4, 0xdbef, 0x44df, 0x81, 0x26, 0xa3, 0x1a, 0x89, 0x12, 0x1d, 220), Version(0x6020000), WebHostHidden]
    public interface ICollectionView : IObservableVector<object>, IVector<object>, IIterable<object>
    {
        event Windows.Foundation.EventHandler<object> CurrentChanged;

        event CurrentChangingEventHandler CurrentChanging;

        bool IsPlaceholder([In] object item);
        IAsyncOperation<LoadMoreItemsResult> LoadMoreItemsAsync([In] uint count);
        bool MoveCurrentTo([In] object item);
        bool MoveCurrentToFirst();
        bool MoveCurrentToLast();
        bool MoveCurrentToNext();
        bool MoveCurrentToPosition([In] int index);
        bool MoveCurrentToPrevious();

        IObservableVector<object> CollectionGroups { get; }

        object CurrentItem { get; }

        int CurrentPosition { get; }

        bool HasMoreItems { get; }

        bool IsCurrentAfterLast { get; }

        bool IsCurrentBeforeFirst { get; }
    }
}

