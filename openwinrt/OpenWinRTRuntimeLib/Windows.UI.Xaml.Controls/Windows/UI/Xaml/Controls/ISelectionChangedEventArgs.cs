namespace Windows.UI.Xaml.Controls
{
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Guid(0xc972d2dc, 0xb609, 0x4758, 0x85, 30, 0xa7, 0x99, 0xc2, 0x1d, 0xe9, 0x7d), Version(0x6020000), ExclusiveTo(typeof(SelectionChangedEventArgs)), WebHostHidden]
    internal interface ISelectionChangedEventArgs
    {
        IVector<object> AddedItems { get; }

        IVector<object> RemovedItems { get; }
    }
}

