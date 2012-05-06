namespace Windows.Data.Xml.Dom
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x1c741d59, 0x2122, 0x47d5, 0xa8, 0x56, 0x83, 0xf3, 0xd4, 0x21, 0x48, 0x75), Version(0x6020000)]
    public interface IXmlNode : IXmlNodeSelector, IXmlNodeSerializer
    {
        IXmlNode AppendChild([In] IXmlNode newChild);
        IXmlNode CloneNode([In] bool deep);
        bool HasChildNodes();
        IXmlNode InsertBefore([In] IXmlNode newChild, [In] IXmlNode referenceChild);
        void Normalize();
        IXmlNode RemoveChild([In] IXmlNode childNode);
        IXmlNode ReplaceChild([In] IXmlNode newChild, [In] IXmlNode referenceChild);

        XmlNamedNodeMap Attributes { get; }

        XmlNodeList ChildNodes { get; }

        IXmlNode FirstChild { get; }

        IXmlNode LastChild { get; }

        object LocalName { [return: Variant] get; }

        object NamespaceUri { [return: Variant] get; }

        IXmlNode NextSibling { get; }

        string NodeName { get; }

        Windows.Data.Xml.Dom.NodeType NodeType { get; }

        object NodeValue { [return: Variant] get; [param: In, Variant] set; }

        XmlDocument OwnerDocument { get; }

        IXmlNode ParentNode { get; }

        object Prefix { [return: Variant] get; [param: In, Variant] set; }

        IXmlNode PreviousSibling { get; }
    }
}

