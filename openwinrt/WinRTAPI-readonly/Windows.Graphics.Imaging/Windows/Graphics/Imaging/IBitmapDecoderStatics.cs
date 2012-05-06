namespace Windows.Graphics.Imaging
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x71bba3bd, 0x16fd, 0x41fd, 0x8f, 0x5c, 0x3f, 0x5f, 0xe9, 30, 0xde, 180), ExclusiveTo(typeof(BitmapDecoder))]
    internal interface IBitmapDecoderStatics
    {
        [Overload("CreateAsync"), DefaultOverload]
        IAsyncOperation<BitmapDecoder> CreateAsync([In] IRandomAccessStream stream);
        [Overload("CreateWithIdAsync"), DefaultOverload]
        IAsyncOperation<BitmapDecoder> CreateAsync([In] Guid decoderId, [In] IRandomAccessStream stream);
        IVectorView<BitmapCodecInformation> GetDecoderInformationEnumerator([In] BitmapCodecEnumerationFilter filter);

        Guid BmpDecoderId { get; }

        Guid GifDecoderId { get; }

        Guid IcoDecoderId { get; }

        Guid JpegDecoderId { get; }

        Guid JpegXRDecoderId { get; }

        Guid PngDecoderId { get; }

        Guid TiffDecoderId { get; }
    }
}

