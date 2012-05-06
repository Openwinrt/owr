namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x9e942ae7, 0x3761, 0x447f, 0x8f, 0x97, 0x29, 0xe3, 0x9d, 0x5e, 0xb3, 0x10), WebHostHidden, Version(0x6020000), ExclusiveTo(typeof(StyleSelector))]
    internal interface IStyleSelectorFactory
    {
        StyleSelector CreateInstance([In] object outer, out object inner);
    }
}

