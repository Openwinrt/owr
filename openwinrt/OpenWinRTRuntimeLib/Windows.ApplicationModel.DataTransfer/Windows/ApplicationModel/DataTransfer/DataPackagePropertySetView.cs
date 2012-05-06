namespace Windows.ApplicationModel.DataTransfer
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [Version(0x6020000), DualApiPartition(version=0x6020000)]
    public sealed class DataPackagePropertySetView : IDataPackagePropertySetView, IMapView<string, object>, IIterable<IKeyValuePair<string, object>>
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IIterator<IKeyValuePair<string, object>> First();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool HasKey([In] string key);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public object Lookup([In] string key);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Split(out IMapView<string, object> first, out IMapView<string, object> second);

        public Uri ApplicationListingUri { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string ApplicationName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Description { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVectorView<string> FileTypes { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Size { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public RandomAccessStreamReference Thumbnail { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Title { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Uri Windows.ApplicationModel.DataTransfer.IDataPackagePropertySetView.ApplicationListingUri { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.ApplicationModel.DataTransfer.IDataPackagePropertySetView.ApplicationName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.ApplicationModel.DataTransfer.IDataPackagePropertySetView.Description { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVectorView<string> Windows.ApplicationModel.DataTransfer.IDataPackagePropertySetView.FileTypes { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public RandomAccessStreamReference Windows.ApplicationModel.DataTransfer.IDataPackagePropertySetView.Thumbnail { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.ApplicationModel.DataTransfer.IDataPackagePropertySetView.Title { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

