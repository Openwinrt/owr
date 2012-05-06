namespace Windows.UI.Xaml.Media.Imaging
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(WriteableBitmap)), WebHostHidden, Version(0x6020000), Windows.Foundation.Metadata.Guid(0x5563ebb1, 0x3ef2, 0x42c5, 0x9c, 0x6d, 0x1c, 0xf5, 220, 0xc0, 0x41, 0xff)]
    internal interface IWriteableBitmapFactory
    {
        WriteableBitmap CreateInstanceWithDimensions([In] int pixelWidth, [In] int pixelHeight);
    }
}

