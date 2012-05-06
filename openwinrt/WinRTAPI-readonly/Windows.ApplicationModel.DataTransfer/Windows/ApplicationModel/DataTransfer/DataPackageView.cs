namespace Windows.ApplicationModel.DataTransfer
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [DualApiPartition(version=0x6020000), Version(0x6020000)]
    public sealed class DataPackageView : IDataPackageView
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool Contains([In] string formatId);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperation<RandomAccessStreamReference> GetBitmapAsync();
        [return: HasVariant]
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperation<object> GetDataAsync([In] string formatId);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperation<string> GetHtmlFormatAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperation<IMapView<string, RandomAccessStreamReference>> GetResourceMapAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperation<string> GetRtfAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperation<IVectorView<IStorageItem>> GetStorageItemsAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("GetTextAsync")]
        public IAsyncOperation<string> GetTextAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("GetCustomTextAsync")]
        public IAsyncOperation<string> GetTextAsync([In] string formatId);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperation<Uri> GetUriAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void ReportOperationCompleted([In] DataPackageOperation value);

        public IVectorView<string> AvailableFormats { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public DataPackagePropertySetView Properties { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public DataPackageOperation RequestedOperation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVectorView<string> Windows.ApplicationModel.DataTransfer.IDataPackageView.AvailableFormats { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public DataPackagePropertySetView Windows.ApplicationModel.DataTransfer.IDataPackageView.Properties { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public DataPackageOperation Windows.ApplicationModel.DataTransfer.IDataPackageView.RequestedOperation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

