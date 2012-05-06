namespace Windows.Data.Xml.Dom
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Storage;

    [Activatable(0x6020000), Version(0x6020000), Static(typeof(IXmlDocumentStatics), 0x6020000), Threading(ThreadingModel.Both), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class XmlDocument : IXmlDocument, IXmlNode, IXmlNodeSelector, IXmlNodeSerializer, IXmlDocumentIO
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public XmlDocument();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IXmlNode AppendChild([In] IXmlNode newChild);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IXmlNode CloneNode([In] bool deep);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public XmlAttribute CreateAttribute([In] string name);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public XmlAttribute CreateAttributeNS([In, Variant] object namespaceUri, [In] string qualifiedName);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public XmlCDataSection CreateCDataSection([In] string data);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public XmlComment CreateComment([In] string data);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public XmlDocumentFragment CreateDocumentFragment();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public XmlElement CreateElement([In] string tagName);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public XmlElement CreateElementNS([In, Variant] object namespaceUri, [In] string qualifiedName);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public XmlEntityReference CreateEntityReference([In] string name);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public XmlProcessingInstruction CreateProcessingInstruction([In] string target, [In] string data);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public XmlText CreateTextNode([In] string data);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public XmlElement GetElementById([In] string elementId);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public XmlNodeList GetElementsByTagName([In] string tagName);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public string GetXml();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool HasChildNodes();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IXmlNode ImportNode([In] IXmlNode node, [In] bool deep);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IXmlNode InsertBefore([In] IXmlNode newChild, [In] IXmlNode referenceChild);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("LoadFromFileAsync")]
        public static IAsyncOperation<XmlDocument> LoadFromFileAsync([In] IStorageFile file);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("LoadFromFileWithSettingsAsync")]
        public static IAsyncOperation<XmlDocument> LoadFromFileAsync([In] IStorageFile file, [In] XmlLoadSettings loadSettings);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("LoadFromUriAsync")]
        public static IAsyncOperation<XmlDocument> LoadFromUriAsync([In] Uri uri);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("LoadFromUriWithSettingsAsync")]
        public static IAsyncOperation<XmlDocument> LoadFromUriAsync([In] Uri uri, [In] XmlLoadSettings loadSettings);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("LoadXml")]
        public void LoadXml([In] string xml);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("LoadXmlWithSettings")]
        public void LoadXml([In] string xml, [In] XmlLoadSettings loadSettings);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Normalize();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IXmlNode RemoveChild([In] IXmlNode childNode);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IXmlNode ReplaceChild([In] IXmlNode newChild, [In] IXmlNode referenceChild);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncAction SaveToFileAsync([In] IStorageFile file);
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

        public XmlDocumentType Doctype { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public XmlElement DocumentElement { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string DocumentUri { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IXmlNode FirstChild { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public XmlDomImplementation Implementation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

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

        public XmlDocumentType Windows.Data.Xml.Dom.IXmlDocument.Doctype { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public XmlElement Windows.Data.Xml.Dom.IXmlDocument.DocumentElement { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Data.Xml.Dom.IXmlDocument.DocumentUri { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public XmlDomImplementation Windows.Data.Xml.Dom.IXmlDocument.Implementation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

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

