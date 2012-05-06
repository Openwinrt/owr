namespace Windows.ApplicationModel.DataTransfer
{
    using System;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [HasVariant, Guid(0xb94cec01, 0xc1a, 0x4c57, 190, 0x55, 0x75, 0xd0, 0x12, 0x89, 0x73, 0x5d), Version(0x6020000), ExclusiveTo(typeof(DataPackagePropertySetView))]
    internal interface IDataPackagePropertySetView : IMapView<string, object>, IIterable<IKeyValuePair<string, object>>
    {
        Uri ApplicationListingUri { get; }

        string ApplicationName { get; }

        string Description { get; }

        IVectorView<string> FileTypes { get; }

        RandomAccessStreamReference Thumbnail { get; }

        string Title { get; }
    }
}

