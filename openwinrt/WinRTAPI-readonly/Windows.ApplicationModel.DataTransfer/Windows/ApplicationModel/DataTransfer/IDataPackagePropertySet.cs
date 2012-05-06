namespace Windows.ApplicationModel.DataTransfer
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [Version(0x6020000), ExclusiveTo(typeof(DataPackagePropertySet)), Windows.Foundation.Metadata.Guid(0xcd1c93eb, 0x4c4c, 0x443a, 0xa8, 0xd3, 0xf5, 0xc2, 0x41, 0xe9, 0x16, 0x89), HasVariant]
    internal interface IDataPackagePropertySet : IMap<string, object>, IIterable<IKeyValuePair<string, object>>
    {
        Uri ApplicationListingUri { get; [param: In] set; }

        string ApplicationName { get; [param: In] set; }

        string Description { get; [param: In] set; }

        IVector<string> FileTypes { get; }

        IRandomAccessStreamReference Thumbnail { get; [param: In] set; }

        string Title { get; [param: In] set; }
    }
}

