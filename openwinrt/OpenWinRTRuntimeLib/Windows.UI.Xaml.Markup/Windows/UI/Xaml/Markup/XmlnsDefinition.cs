namespace Windows.UI.Xaml.Markup
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [StructLayout(LayoutKind.Sequential), Version(0x6020000), WebHostHidden]
    public struct XmlnsDefinition
    {
        public string XmlNamespace;
        public string Namespace;
    }
}

