namespace Windows.Data.Xml.Dom
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Storage;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x6cd0e74e, 0xee65, 0x4489, 0x9e, 0xbf, 0xca, 0x43, 0xe8, 0x7b, 0xa6, 0x37), ExclusiveTo(typeof(XmlDocument))]
    internal interface IXmlDocumentIO
    {
        [Overload("LoadXml")]
        void LoadXml([In] string xml);
        [Overload("LoadXmlWithSettings")]
        void LoadXml([In] string xml, [In] XmlLoadSettings loadSettings);
        IAsyncAction SaveToFileAsync([In] IStorageFile file);
    }
}

