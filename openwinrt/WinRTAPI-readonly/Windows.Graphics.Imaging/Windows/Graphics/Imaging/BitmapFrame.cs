namespace Windows.Graphics.Imaging
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000)]
    public sealed class BitmapFrame : IBitmapFrame
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("GetPixelDataAsync"), DefaultOverload]
        public IAsyncOperation<PixelDataProvider> GetPixelDataAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), DefaultOverload, Overload("GetPixelDataTransformedAsync")]
        public IAsyncOperation<PixelDataProvider> GetPixelDataAsync([In] Windows.Graphics.Imaging.BitmapPixelFormat pixelFormat, [In] Windows.Graphics.Imaging.BitmapAlphaMode alphaMode, [In] BitmapTransform transform, [In] ExifOrientationMode exifOrientationMode, [In] ColorManagementMode colorManagementMode);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperation<ImageStream> GetThumbnailAsync();

        public Windows.Graphics.Imaging.BitmapAlphaMode BitmapAlphaMode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Graphics.Imaging.BitmapPixelFormat BitmapPixelFormat { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public BitmapPropertiesView BitmapProperties { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double DpiX { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double DpiY { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint OrientedPixelHeight { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint OrientedPixelWidth { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint PixelHeight { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint PixelWidth { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

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

