namespace Windows.UI.Xaml.Controls
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Version(0x6020000), ExclusiveTo(typeof(ListViewBase)), Guid(0x8532b8f7, 0x3e16, 0x455b, 0x89, 0xa8, 0xc1, 0x34, 0x62, 0x23, 0xf6, 0xd3), WebHostHidden]
    internal interface IListViewBaseStatics
    {
        DependencyProperty CanDragItemsProperty { get; }

        DependencyProperty CanReorderItemsProperty { get; }

        DependencyProperty DataFetchSizeProperty { get; }

        DependencyProperty IncrementalLoadingThresholdProperty { get; }

        DependencyProperty IncrementalLoadingTriggerProperty { get; }

        DependencyProperty IsActiveViewProperty { get; }

        DependencyProperty IsItemClickEnabledProperty { get; }

        DependencyProperty IsSwipeEnabledProperty { get; }

        DependencyProperty IsZoomedInViewProperty { get; }

        DependencyProperty PreferIncrementalLoadingProperty { get; }

        DependencyProperty SelectionModeProperty { get; }

        DependencyProperty SemanticZoomOwnerProperty { get; }
    }
}

