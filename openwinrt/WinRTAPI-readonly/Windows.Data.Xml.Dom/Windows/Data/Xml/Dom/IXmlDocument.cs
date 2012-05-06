namespace Windows.Data.Xml.Dom
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(XmlDocument)), Windows.Foundation.Metadata.Guid(0xf7f3a506, 0x1e87, 0x42d6, 0xbc, 0xfb, 0xb8, 200, 9, 250, 0x54, 0x94), Version(0x6020000)]
    internal interface IXmlDocument : IXmlNode, IXmlNodeSelector, IXmlNodeSerializer
    {
        XmlAttribute CreateAttribute([In] string name);
        XmlAttribute CreateAttributeNS([In, Variant] object namespaceUri, [In] string qualifiedName);
        XmlCDataSection CreateCDataSection([In] string data);
        XmlComment CreateComment([In] string data);
        XmlDocumentFragment CreateDocumentFragment();
        XmlElement CreateElement([In] string tagName);
        XmlElement CreateElementNS([In, Variant] object namespaceUri, [In] string qualifiedName);
        XmlEntityReference CreateEntityReference([In] string name);
        XmlProcessingInstruction CreateProcessingInstruction([In] string target, [In] string data);
        XmlText CreateTextNode([In] string data);
        XmlElement GetElementById([In] string elementId);
        XmlNodeList GetElementsByTagName([In] string tagName);
        IXmlNode ImportNode([In] IXmlNode node, [In] bool deep);

        XmlDocumentType Doctype { get; }

        XmlElement DocumentElement { get; }

        string DocumentUri { get; }

        XmlDomImplementation Implementation { get; }
    }
}

