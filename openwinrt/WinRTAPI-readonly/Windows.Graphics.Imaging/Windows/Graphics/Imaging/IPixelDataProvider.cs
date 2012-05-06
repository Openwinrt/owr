namespace Windows.Graphics.Imaging
{
    using System;
    using Windows.Foundation.Metadata;

    [Guid(0xdd831f25, 0x185c, 0x4595, 0x9f, 0xb9, 0xcc, 190, 110, 0xc1, 0x8a, 0x6f), ExclusiveTo(typeof(PixelDataProvider)), Version(0x6020000)]
    internal interface IPixelDataProvider
    {
        byte[] DetachPixelData();
    }
}

