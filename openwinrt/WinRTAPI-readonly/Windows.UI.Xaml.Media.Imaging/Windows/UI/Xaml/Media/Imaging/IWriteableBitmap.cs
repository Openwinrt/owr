namespace Windows.UI.Xaml.Media.Imaging
{
    using System;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [Version(0x6020000), ExclusiveTo(typeof(WriteableBitmap)), Guid(0xbf0b7e6f, 0xdf7c, 0x4a85, 0x84, 0x13, 0xa1, 0x21, 0x62, 0x85, 0x83, 0x5c), WebHostHidden]
    internal interface IWriteableBitmap
    {
        void Invalidate();

        IBuffer PixelBuffer { get; }
    }
}

