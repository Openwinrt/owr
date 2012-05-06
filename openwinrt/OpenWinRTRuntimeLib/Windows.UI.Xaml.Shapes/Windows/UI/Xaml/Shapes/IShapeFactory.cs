namespace Windows.UI.Xaml.Shapes
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(Shape)), Windows.Foundation.Metadata.Guid(0x4b717613, 0xf6aa, 0x48d5, 0x95, 0x88, 0xe1, 0xd1, 0x88, 0xea, 0xcb, 0xc9), WebHostHidden, Version(0x6020000)]
    internal interface IShapeFactory
    {
        Shape CreateInstance([In] object outer, out object inner);
    }
}

