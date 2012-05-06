namespace Windows.Data.Xml.Dom
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000)]
    public sealed class DtdNotation : IDtdNotation, IXmlNode, IXmlNodeSelector, IXmlNodeSerializer
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IXmlNode AppendChild([In] IXmlNode newChild);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IXmlNode CloneNode([In] bool deep);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public string GetXml();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool HasChildNodes();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IXmlNode InsertBefore([In] IXmlNode newChild, [In] IXmlNode referenceChild);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Normalize();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IXmlNode RemoveChild([In] IXmlNode childNode);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IXmlNode ReplaceChild([In] IXmlNode newChild, [In] IXmlNode referenceChild);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public XmlNodeList SelectNodes([In] string xpath);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public XmlNodeList SelectNodesNS([In] string xpath, [In, Variant] object namespaces);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IXmlNode SelectSingleNode([In] string xpath);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IXmlNode SelectSingleNodeNS([In] string xpath, [In, Variant] object namespaces);

        public XmlNamedNodeMap Attributes { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public XmlNodeList ChildNodes { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IXmlNode FirstChild { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string InnerText { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IXmlNode LastChild { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public object LocalName { [return: Variant] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public object NamespaceUri { [return: Variant] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IXmlNode NextSibling { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string NodeName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Data.Xml.Dom.NodeType NodeType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public object NodeValue { [return: Variant] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In, Variant] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public XmlDocument OwnerDocument { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IXmlNode ParentNode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public object Prefix { [return: Variant] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In, Variant] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IXmlNode PreviousSibling { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public object PublicId { [return: Variant] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public object SystemId { [return: Variant] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public object Windows.Data.Xml.Dom.IDtdNotation.PublicId { [return: Variant] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public object Windows.Data.Xml.Dom.IDtdNotation.SystemId { [return: Variant] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public XmlNamedNodeMap Windows.Data.Xml.Dom.IXmlNode.Attributes { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public XmlNodeList Windows.Data.Xml.Dom.IXmlNode.ChildNodes { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IXmlNode Windows.Data.Xml.Dom.IXmlNode.FirstChild { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IXmlNode Windows.Data.Xml.Dom.IXmlNode.LastChild { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public object Windows.Data.Xml.Dom.IXmlNode.LocalName { [return: Variant] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public object Windows.Data.Xml.Dom.IXmlNode.NamespaceUri { [return: Variant] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IXmlNode Windows.Data.Xml.Dom.IXmlNode.NextSibling { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Data.Xml.Dom.IXmlNode.NodeName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Data.Xml.Dom.NodeType Windows.Data.Xml.Dom.IXmlNode.NodeType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public object Windows.Data.Xml.Dom.IXmlNode.NodeValue { [return: Variant] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In, Variant] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public XmlDocument Windows.Data.Xml.Dom.IXmlNode.OwnerDocument { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IXmlNode Windows.Data.Xml.Dom.IXmlNode.ParentNode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public object Windows.Data.Xml.Dom.IXmlNode.Prefix { [return: Variant] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In, Variant] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IXmlNode Windows.Data.Xml.Dom.IXmlNode.PreviousSibling { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Data.Xml.Dom.IXmlNodeSerializer.InnerText { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

