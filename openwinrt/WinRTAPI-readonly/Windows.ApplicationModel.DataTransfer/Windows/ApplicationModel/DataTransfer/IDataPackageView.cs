namespace Windows.ApplicationModel.DataTransfer
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(DataPackageView)), Windows.Foundation.Metadata.Guid(0x7b840471, 0x5900, 0x4d85, 0xa9, 11, 0x10, 0xcb, 0x85, 0xfe, 0x35, 0x52), Version(0x6020000)]
    internal interface IDataPackageView
    {
        bool Contains([In] string formatId);
        IAsyncOperation<RandomAccessStreamReference> GetBitmapAsync();
        [return: HasVariant]
        IAsyncOperation<object> GetDataAsync([In] string formatId);
        IAsyncOperation<string> GetHtmlFormatAsync();
        IAsyncOperation<IMapView<string, RandomAccessStreamReference>> GetResourceMapAsync();
        IAsyncOperation<string> GetRtfAsync();
        IAsyncOperation<IVectorView<IStorageItem>> GetStorageItemsAsync();
        [Overload("GetTextAsync")]
        IAsyncOperation<string> GetTextAsync();
        [Overload("GetCustomTextAsync")]
        IAsyncOperation<string> GetTextAsync([In] string formatId);
        IAsyncOperation<Uri> GetUriAsync();
        void ReportOperationCompleted([In] DataPackageOperation value);

        IVectorView<string> AvailableFormats { get; }

        DataPackagePropertySetView Properties { get; }

        DataPackageOperation RequestedOperation { get; }
    }
}

