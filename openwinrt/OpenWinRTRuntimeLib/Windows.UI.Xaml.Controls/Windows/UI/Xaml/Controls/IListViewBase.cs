namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x3d0813ba, 0x6890, 0x4537, 0xbf, 0xe5, 0x79, 0x6d, 0x94, 0x58, 0xed, 0xd6), ExclusiveTo(typeof(ListViewBase)), WebHostHidden, Version(0x6020000)]
    internal interface IListViewBase
    {
        event DragItemsStartingEventHandler DragItemsStarting;

        event ItemClickEventHandler ItemClick;

        IAsyncOperation<LoadMoreItemsResult> LoadMoreItemsAsync();
        void ScrollIntoView([In] object item);
        void SelectAll();

        bool CanDragItems { get; [param: In] set; }

        bool CanReorderItems { get; [param: In] set; }

        double DataFetchSize { get; [param: In] set; }

        double IncrementalLoadingThreshold { get; [param: In] set; }

        Windows.UI.Xaml.Controls.IncrementalLoadingTrigger IncrementalLoadingTrigger { get; [param: In] set; }

        bool IsItemClickEnabled { get; [param: In] set; }

        bool IsSwipeEnabled { get; [param: In] set; }

        bool PreferIncrementalLoading { get; [param: In] set; }

        IVector<object> SelectedItems { get; }

        ListViewSelectionMode SelectionMode { get; [param: In] set; }
    }
}

