namespace Windows.UI.Xaml.Data
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x7f5ee992, 0x7694, 0x4e6c, 0xa5, 0x1b, 0xe3, 0x4b, 0xf4, 0x3d, 0xe7, 0x43), WebHostHidden]
    public interface ISupportIncrementalLoading
    {
        IAsyncOperation<LoadMoreItemsResult> LoadMoreItemsAsync([In] uint count);

        bool HasMoreItems { get; }
    }
}

