namespace Windows.Graphics.Imaging
{
    using System;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Guid(0xcd8044a9, 0x2443, 0x4000, 0xb0, 0xcd, 0x79, 0x31, 0x6c, 0x56, 0xf5, 0x89), ExclusiveTo(typeof(BitmapTypedValue)), Version(0x6020000)]
    internal interface IBitmapTypedValue
    {
        PropertyType Type { get; }

        object Value { get; }
    }
}

