namespace Windows.Graphics.Imaging
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [Windows.Foundation.Metadata.Guid(0x38a2da39, 0x5ebe, 0x45fc, 0xb2, 0xd8, 0x7d, 0x10, 0x9d, 0xde, 0x74, 0x7f), ExclusiveTo(typeof(BitmapEncoder)), Version(0x6020000)]
    internal interface IBitmapEncoderStatics
    {
        [DefaultOverload, Overload("CreateAsync")]
        IAsyncOperation<BitmapEncoder> CreateAsync([In] Guid encoderId, [In] IRandomAccessStream stream);
        [DefaultOverload, Overload("CreateWithEncodingOptionsAsync")]
        IAsyncOperation<BitmapEncoder> CreateAsync([In] Guid encoderId, [In] IRandomAccessStream stream, [In] IIterable<IKeyValuePair<string, BitmapTypedValue>> encodingOptions);
        IAsyncOperation<BitmapEncoder> CreateForInPlacePropertyEncodingAsync([In] BitmapDecoder bitmapDecoder);
        IAsyncOperation<BitmapEncoder> CreateForTranscodingAsync([In] IRandomAccessStream stream, [In] BitmapDecoder bitmapDecoder);
        IVectorView<BitmapCodecInformation> GetEncoderInformationEnumerator([In] BitmapCodecEnumerationFilter filter);

        Guid BmpEncoderId { get; }

        Guid GifEncoderId { get; }

        Guid JpegEncoderId { get; }

        Guid JpegXREncoderId { get; }

        Guid PngEncoderId { get; }

        Guid TiffEncoderId { get; }
    }
}

