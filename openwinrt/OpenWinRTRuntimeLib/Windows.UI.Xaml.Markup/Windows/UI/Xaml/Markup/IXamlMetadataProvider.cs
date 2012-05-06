namespace Windows.UI.Xaml.Markup
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Interop;

    [Version(0x6020000), WebHostHidden, Windows.Foundation.Metadata.Guid(0xb3765d69, 0x68a5, 0x4b32, 0x88, 0x61, 0xfd, 0xb9, 12, 0x1f, 0x58, 0x36)]
    public interface IXamlMetadataProvider
    {
        [Overload("GetXamlTypeByFullName")]
        IXamlType GetXamlType([In] string fullName);
        [DefaultOverload, Overload("GetXamlType")]
        IXamlType GetXamlType([In] TypeName type);
        XmlnsDefinition[] GetXmlnsDefinitions();
    }
}

