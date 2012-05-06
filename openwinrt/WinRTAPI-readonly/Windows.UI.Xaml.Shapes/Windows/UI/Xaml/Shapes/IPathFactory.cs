namespace Windows.UI.Xaml.Shapes
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x2340a4e3, 0x5a86, 0x4fc6, 0x9a, 80, 0xcb, 0xb9, 0x3b, 130, 0x87, 0x66), WebHostHidden, ExclusiveTo(typeof(Path)), Version(0x6020000)]
    internal interface IPathFactory
    {
        Path CreateInstance([In] object outer, out object inner);
    }
}

