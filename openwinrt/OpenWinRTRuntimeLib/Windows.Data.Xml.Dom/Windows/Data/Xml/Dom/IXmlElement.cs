namespace Windows.Data.Xml.Dom
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(XmlElement)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0x2dfb8a1f, 0x6b10, 0x4ef8, 0x9f, 0x83, 0xef, 0xcc, 0xe8, 250, 0xec, 0x37)]
    internal interface IXmlElement : IXmlNode, IXmlNodeSelector, IXmlNodeSerializer
    {
        string GetAttribute([In] string attributeName);
        XmlAttribute GetAttributeNode([In] string attributeName);
        XmlAttribute GetAttributeNodeNS([In, Variant] object namespaceUri, [In] string localName);
        string GetAttributeNS([In, Variant] object namespaceUri, [In] string localName);
        XmlNodeList GetElementsByTagName([In] string tagName);
        void RemoveAttribute([In] string attributeName);
        XmlAttribute RemoveAttributeNode([In] XmlAttribute attributeNode);
        void RemoveAttributeNS([In, Variant] object namespaceUri, [In] string localName);
        void SetAttribute([In] string attributeName, [In] string attributeValue);
        XmlAttribute SetAttributeNode([In] XmlAttribute newAttribute);
        XmlAttribute SetAttributeNodeNS([In] XmlAttribute newAttribute);
        void SetAttributeNS([In, Variant] object namespaceUri, [In] string qualifiedName, [In] string value);

        string TagName { get; }
    }
}

