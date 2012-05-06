namespace Windows.Data.Xml.Dom
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class XmlNodeList : IXmlNodeList, IVectorView<IXmlNode>, IIterable<IXmlNode>
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IIterator<IXmlNode> First();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IXmlNode GetAt([In] uint index);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public uint GetMany([In] uint startIndex, [Out] IXmlNode[] items);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool IndexOf([In] IXmlNode value, out uint index);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IXmlNode Item([In] uint index);

        public uint Length { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Size { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.Data.Xml.Dom.IXmlNodeList.Length { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

