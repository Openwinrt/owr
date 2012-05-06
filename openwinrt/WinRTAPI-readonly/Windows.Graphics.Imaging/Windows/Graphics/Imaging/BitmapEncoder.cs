namespace Windows.Graphics.Imaging
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [Static(typeof(IBitmapEncoderStatics), 0x6020000), Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class BitmapEncoder : IBitmapEncoder
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), DefaultOverload, Overload("CreateAsync")]
        public static IAsyncOperation<BitmapEncoder> CreateAsync([In] Guid encoderId, [In] IRandomAccessStream stream);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), DefaultOverload, Overload("CreateWithEncodingOptionsAsync")]
        public static IAsyncOperation<BitmapEncoder> CreateAsync([In] Guid encoderId, [In] IRandomAccessStream stream, [In] IIterable<IKeyValuePair<string, BitmapTypedValue>> encodingOptions);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IAsyncOperation<BitmapEncoder> CreateForInPlacePropertyEncodingAsync([In] BitmapDecoder bitmapDecoder);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IAsyncOperation<BitmapEncoder> CreateForTranscodingAsync([In] IRandomAccessStream stream, [In] BitmapDecoder bitmapDecoder);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncAction FlushAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IVectorView<BitmapCodecInformation> GetEncoderInformationEnumerator([In] BitmapCodecEnumerationFilter filter);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), DefaultOverload, Overload("GoToNextFrameAsync")]
        public IAsyncAction GoToNextFrameAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), DefaultOverload, Overload("GoToNextFrameWithEncodingOptionsAsync")]
        public IAsyncAction GoToNextFrameAsync([In] IIterable<IKeyValuePair<string, BitmapTypedValue>> encodingOptions);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SetPixelData([In] BitmapPixelFormat pixelFormat, [In] BitmapAlphaMode alphaMode, [In] uint width, [In] uint height, [In] double dpiX, [In] double dpiY, [In, Range(0, 0x7fffffff)] byte[] pixels);

        public Windows.Graphics.Imaging.BitmapProperties BitmapContainerProperties { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Graphics.Imaging.BitmapProperties BitmapProperties { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Graphics.Imaging.BitmapTransform BitmapTransform { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static Guid BmpEncoderId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public BitmapCodecInformation EncoderInformation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint GeneratedThumbnailHeight { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public uint GeneratedThumbnailWidth { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static Guid GifEncoderId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool IsThumbnailGenerated { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static Guid JpegEncoderId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static Guid JpegXREncoderId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static Guid PngEncoderId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static Guid TiffEncoderId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Graphics.Imaging.BitmapProperties Windows.Graphics.Imaging.IBitmapEncoder.BitmapContainerProperties { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Graphics.Imaging.BitmapProperties Windows.Graphics.Imaging.IBitmapEncoder.BitmapProperties { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Graphics.Imaging.BitmapTransform Windows.Graphics.Imaging.IBitmapEncoder.BitmapTransform { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public BitmapCodecInformation Windows.Graphics.Imaging.IBitmapEncoder.EncoderInformation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.Graphics.Imaging.IBitmapEncoder.GeneratedThumbnailHeight { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public uint Windows.Graphics.Imaging.IBitmapEncoder.GeneratedThumbnailWidth { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.Graphics.Imaging.IBitmapEncoder.IsThumbnailGenerated { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

