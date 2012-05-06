namespace Windows.Storage.FileProperties
{
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0xc54361b2, 0x54cd, 0x432b, 0xbd, 0xbc, 0x4b, 0x19, 0xc4, 180, 0x70, 0xd7)]
    public interface IStorageItemExtraProperties
    {
        IAsyncOperation<IMap<string, object>> RetrievePropertiesAsync([In] IIterable<string> propertiesToRetrieve);
        [Overload("SavePropertiesAsyncOverloadDefault")]
        IAsyncAction SavePropertiesAsync();
        [Overload("SavePropertiesAsync")]
        IAsyncAction SavePropertiesAsync([In, HasVariant] IIterable<IKeyValuePair<string, object>> propertiesToSave);
    }
}

