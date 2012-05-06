namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls.Primitives;

    [Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both), WebHostHidden, Composable(typeof(IListViewBaseFactory), CompositionType.Protected, 0x6020000), Static(typeof(IListViewBaseStatics), 0x6020000)]
    public class ListViewBase : Selector, IListViewBase, ISemanticZoomInformation
    {
        public event DragItemsStartingEventHandler DragItemsStarting;

        public event ItemClickEventHandler ItemClick;

        public event DragItemsStartingEventHandler Windows.UI.Xaml.Controls.IListViewBase.DragItemsStarting;

        public event ItemClickEventHandler Windows.UI.Xaml.Controls.IListViewBase.ItemClick;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected ListViewBase();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void CompleteViewChange();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void CompleteViewChangeFrom([In] SemanticZoomLocation source, [In] SemanticZoomLocation destination);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void CompleteViewChangeTo([In] SemanticZoomLocation source, [In] SemanticZoomLocation destination);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void InitializeViewChange();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperation<LoadMoreItemsResult> LoadMoreItemsAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void MakeVisible([In] SemanticZoomLocation item);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void ScrollIntoView([In] object item);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SelectAll();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void StartViewChangeFrom([In] SemanticZoomLocation source, [In] SemanticZoomLocation destination);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void StartViewChangeTo([In] SemanticZoomLocation source, [In] SemanticZoomLocation destination);

        public bool CanDragItems { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty CanDragItemsProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool CanReorderItems { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty CanReorderItemsProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double DataFetchSize { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty DataFetchSizeProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double IncrementalLoadingThreshold { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty IncrementalLoadingThresholdProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Controls.IncrementalLoadingTrigger IncrementalLoadingTrigger { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty IncrementalLoadingTriggerProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool IsActiveView { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty IsActiveViewProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool IsItemClickEnabled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty IsItemClickEnabledProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool IsSwipeEnabled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty IsSwipeEnabledProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool IsZoomedInView { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty IsZoomedInViewProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool PreferIncrementalLoading { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty PreferIncrementalLoadingProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVector<object> SelectedItems { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ListViewSelectionMode SelectionMode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty SelectionModeProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public SemanticZoom SemanticZoomOwner { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty SemanticZoomOwnerProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Xaml.Controls.IListViewBase.CanDragItems { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.UI.Xaml.Controls.IListViewBase.CanReorderItems { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public double Windows.UI.Xaml.Controls.IListViewBase.DataFetchSize { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public double Windows.UI.Xaml.Controls.IListViewBase.IncrementalLoadingThreshold { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.UI.Xaml.Controls.IncrementalLoadingTrigger Windows.UI.Xaml.Controls.IListViewBase.IncrementalLoadingTrigger { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.UI.Xaml.Controls.IListViewBase.IsItemClickEnabled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.UI.Xaml.Controls.IListViewBase.IsSwipeEnabled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.UI.Xaml.Controls.IListViewBase.PreferIncrementalLoading { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IVector<object> Windows.UI.Xaml.Controls.IListViewBase.SelectedItems { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ListViewSelectionMode Windows.UI.Xaml.Controls.IListViewBase.SelectionMode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.UI.Xaml.Controls.ISemanticZoomInformation.IsActiveView { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.UI.Xaml.Controls.ISemanticZoomInformation.IsZoomedInView { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public SemanticZoom Windows.UI.Xaml.Controls.ISemanticZoomInformation.SemanticZoomOwner { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

