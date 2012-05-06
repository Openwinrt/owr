namespace Windows.ApplicationModel.DataTransfer
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [DualApiPartition(version=0x6020000), Activatable(0x6020000), Version(0x6020000)]
    public sealed class DataPackage : IDataPackage
    {
        public event TypedEventHandler<DataPackage, object> Destroyed;

        public event TypedEventHandler<DataPackage, OperationCompletedEventArgs> OperationCompleted;

        public event TypedEventHandler<DataPackage, object> Windows.ApplicationModel.DataTransfer.IDataPackage.Destroyed;

        public event TypedEventHandler<DataPackage, OperationCompletedEventArgs> Windows.ApplicationModel.DataTransfer.IDataPackage.OperationCompleted;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public DataPackage();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public DataPackageView GetView();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SetBitmap([In] RandomAccessStreamReference value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SetData([In] string formatId, [In, HasVariant] object value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SetDataProvider([In] string formatId, [In] DataProviderHandler delayRenderer);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SetHtmlFormat([In] string value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SetRtf([In] string value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("SetStorageItemsReadOnly")]
        public void SetStorageItems([In] IIterable<IStorageItem> value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("SetStorageItems")]
        public void SetStorageItems([In] IIterable<IStorageItem> value, [In] bool readOnly);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SetText([In] string value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SetUri([In] Uri value);

        public DataPackagePropertySet Properties { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public DataPackageOperation RequestedOperation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IMap<string, RandomAccessStreamReference> ResourceMap { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public DataPackagePropertySet Windows.ApplicationModel.DataTransfer.IDataPackage.Properties { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public DataPackageOperation Windows.ApplicationModel.DataTransfer.IDataPackage.RequestedOperation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IMap<string, RandomAccessStreamReference> Windows.ApplicationModel.DataTransfer.IDataPackage.ResourceMap { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

