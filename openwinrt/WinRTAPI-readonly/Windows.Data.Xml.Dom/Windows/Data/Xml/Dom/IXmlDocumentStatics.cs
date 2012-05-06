namespace Windows.Data.Xml.Dom
{
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Storage;

    [ExclusiveTo(typeof(XmlDocument)), Windows.Foundation.Metadata.Guid(0x5543d254, 0xd757, 0x4b79, 0x95, 0x39, 0x23, 0x2b, 0x18, 0xf5, 11, 0xf1), Version(0x6020000)]
    internal interface IXmlDocumentStatics
    {
        [Overload("LoadFromFileAsync")]
        IAsyncOperation<XmlDocument> LoadFromFileAsync([In] IStorageFile file);
        [Overload("LoadFromFileWithSettingsAsync")]
        IAsyncOperation<XmlDocument> LoadFromFileAsync([In] IStorageFile file, [In] XmlLoadSettings loadSettings);
        [Overload("LoadFromUriAsync")]
        IAsyncOperation<XmlDocument> LoadFromUriAsync([In] Uri uri);
        [Overload("LoadFromUriWithSettingsAsync")]
        IAsyncOperation<XmlDocument> LoadFromUriAsync([In] Uri uri, [In] XmlLoadSettings loadSettings);
    }
}

