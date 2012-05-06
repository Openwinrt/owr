namespace Windows.Data.Xml.Dom
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x8c60ad77, 0x83a4, 0x4ec1, 0x9c, 0x54, 0x7b, 0xa4, 0x29, 0xe1, 0x3d, 0xa6), ExclusiveTo(typeof(XmlNodeList))]
    internal interface IXmlNodeList : IVectorView<IXmlNode>, IIterable<IXmlNode>
    {
        IXmlNode Item([In] uint index);

        uint Length { get; }
    }
}

