namespace Windows.UI.Xaml.Markup
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Windows.Foundation.Metadata.Guid(0x9891c6bd, 0x534f, 0x4955, 0xb8, 90, 0x8a, 0x8d, 0xc0, 220, 0xa6, 2), Version(0x6020000), ExclusiveTo(typeof(XamlReader))]
    internal interface IXamlReaderStatics
    {
        object Load([In] string xaml);
        object LoadWithInitialTemplateValidation([In] string xaml);
    }
}

