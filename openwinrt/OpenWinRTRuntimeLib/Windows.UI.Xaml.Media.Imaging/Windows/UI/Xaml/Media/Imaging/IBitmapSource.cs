namespace Windows.UI.Xaml.Media.Imaging
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [ExclusiveTo(typeof(BitmapSource)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0x23d86411, 0x202f, 0x41b2, 140, 0x5b, 0xa8, 0xa3, 0xb3, 0x33, 0x80, 11), WebHostHidden]
    internal interface IBitmapSource
    {
        void SetSource([In] IRandomAccessStream streamSource);

        int PixelHeight { get; }

        int PixelWidth { get; }
    }
}

