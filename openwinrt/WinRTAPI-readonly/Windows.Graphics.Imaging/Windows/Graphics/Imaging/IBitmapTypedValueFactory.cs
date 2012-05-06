namespace Windows.Graphics.Imaging
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x92dbb599, 0xce13, 0x46bb, 0x95, 0x45, 0xcb, 0x3a, 0x3f, 0x63, 0xeb, 0x8b), ExclusiveTo(typeof(BitmapTypedValue))]
    internal interface IBitmapTypedValueFactory
    {
        BitmapTypedValue Create([In] object value, [In] PropertyType type);
    }
}

