namespace Windows.Data.Xml.Dom
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x132e42ab, 0x4e36, 0x4df6, 0xb1, 200, 12, 230, 0x2f, 0xd8, 0x8b, 0x26)]
    public interface IXmlCharacterData : IXmlNode, IXmlNodeSelector, IXmlNodeSerializer
    {
        void AppendData([In] string data);
        void DeleteData([In] uint offset, [In] uint count);
        void InsertData([In] uint offset, [In] string data);
        void ReplaceData([In] uint offset, [In] uint count, [In] string data);
        string SubstringData([In] uint offset, [In] uint count);

        string Data { get; [param: In] set; }

        uint Length { get; }
    }
}

