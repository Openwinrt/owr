namespace Windows.Graphics.Imaging
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [Static(typeof(IBitmapDecoderStatics), 0x6020000), Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class BitmapDecoder : IBitmapDecoder, IBitmapFrame
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), DefaultOverload, Overload("CreateAsync")]
        public static IAsyncOperation<BitmapDecoder> CreateAsync([In] IRandomAccessStream stream);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), DefaultOverload, Overload("CreateWithIdAsync")]
        public static IAsyncOperation<BitmapDecoder> CreateAsync([In] Guid decoderId, [In] IRandomAccessStream stream);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IVectorView<BitmapCodecInformation> GetDecoderInformationEnumerator([In] BitmapCodecEnumerationFilter filter);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperation<BitmapFrame> GetFrameAsync([In] uint frameIndex);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), DefaultOverload, Overload("GetPixelDataAsync")]
        public IAsyncOperation<PixelDataProvider> GetPixelDataAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("GetPixelDataTransformedAsync"), DefaultOverload]
        public IAsyncOperation<PixelDataProvider> GetPixelDataAsync([In] Windows.Graphics.Imaging.BitmapPixelFormat pixelFormat, [In] Windows.Graphics.Imaging.BitmapAlphaMode alphaMode, [In] BitmapTransform transform, [In] ExifOrientationMode exifOrientationMode, [In] ColorManagementMode colorManagementMode);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperation<ImageStream> GetPreviewAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperation<ImageStream> GetThumbnailAsync();

        public Windows.Graphics.Imaging.BitmapAlphaMode BitmapAlphaMode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public BitmapPropertiesView BitmapContainerProperties { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Graphics.Imaging.BitmapPixelFormat BitmapPixelFormat { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public BitmapPropertiesView BitmapProperties { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static Guid BmpDecoderId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public BitmapCodecInformation DecoderInformation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double DpiX { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double DpiY { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint FrameCount { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static Guid GifDecoderId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static Guid IcoDecoderId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static Guid JpegDecoderId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static Guid JpegXRDecoderId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint OrientedPixelHeight { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint OrientedPixelWidth { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint PixelHeight { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint PixelWidth { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static Guid PngDecoderId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static Guid TiffDecoderId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public BitmapPropertiesView Windows.Graphics.Imaging.IBitmapDecoder.BitmapContainerProperties { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public BitmapCodecInformation Windows.Graphics.Imaging.IBitmapDecoder.DecoderInformation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.Graphics.Imaging.IBitmapDecoder.FrameCount { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Graphics.Imaging.BitmapAlphaMode Windows.Graphics.Imaging.IBitmapFrame.BitmapAlphaMode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Graphics.Imaging.BitmapPixelFormat Windows.Graphics.Imaging.IBitmapFrame.BitmapPixelFormat { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public BitmapPropertiesView Windows.Graphics.Imaging.IBitmapFrame.BitmapProperties { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.Graphics.Imaging.IBitmapFrame.DpiX { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.Graphics.Imaging.IBitmapFrame.DpiY { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.Graphics.Imaging.IBitmapFrame.OrientedPixelHeight { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.Graphics.Imaging.IBitmapFrame.OrientedPixelWidth { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.Graphics.Imaging.IBitmapFrame.PixelHeight { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.Graphics.Imaging.IBitmapFrame.PixelWidth { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

