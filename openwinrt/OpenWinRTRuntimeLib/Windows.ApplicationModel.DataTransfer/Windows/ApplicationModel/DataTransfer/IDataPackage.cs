namespace Windows.ApplicationModel.DataTransfer
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [ExclusiveTo(typeof(DataPackage)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0x61ebf5c7, 0xefea, 0x4346, 0x95, 0x54, 0x98, 0x1d, 0x7e, 0x19, 0x8f, 0xfe)]
    internal interface IDataPackage
    {
        event TypedEventHandler<DataPackage, object> Destroyed;

        event TypedEventHandler<DataPackage, OperationCompletedEventArgs> OperationCompleted;

        DataPackageView GetView();
        void SetBitmap([In] RandomAccessStreamReference value);
        void SetData([In] string formatId, [In, HasVariant] object value);
        void SetDataProvider([In] string formatId, [In] DataProviderHandler delayRenderer);
        void SetHtmlFormat([In] string value);
        void SetRtf([In] string value);
        [Overload("SetStorageItemsReadOnly")]
        void SetStorageItems([In] IIterable<IStorageItem> value);
        [Overload("SetStorageItems")]
        void SetStorageItems([In] IIterable<IStorageItem> value, [In] bool readOnly);
        void SetText([In] string value);
        void SetUri([In] Uri value);

        DataPackagePropertySet Properties { get; }

        DataPackageOperation RequestedOperation { get; [param: In] set; }

        IMap<string, RandomAccessStreamReference> ResourceMap { get; }
    }
}

