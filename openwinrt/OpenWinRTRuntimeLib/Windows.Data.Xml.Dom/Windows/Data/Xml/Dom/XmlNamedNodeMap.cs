namespace Windows.Data.Xml.Dom
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000)]
    public sealed class XmlNamedNodeMap : IXmlNamedNodeMap, IVectorView<IXmlNode>, IIterable<IXmlNode>
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IIterator<IXmlNode> First();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IXmlNode GetAt([In] uint index);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public uint GetMany([In] uint startIndex, [Out] IXmlNode[] items);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IXmlNode GetNamedItem([In] string name);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IXmlNode GetNamedItemNS([In, Variant] object namespaceUri, [In] string name);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool IndexOf([In] IXmlNode value, out uint index);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IXmlNode Item([In] uint index);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IXmlNode RemoveNamedItem([In] string name);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IXmlNode RemoveNamedItemNS([In, Variant] object namespaceUri, [In] string name);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IXmlNode SetNamedItem([In] IXmlNode node);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IXmlNode SetNamedItemNS([In] IXmlNode node);

        public uint Length { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Size { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.Data.Xml.Dom.IXmlNamedNodeMap.Length { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

