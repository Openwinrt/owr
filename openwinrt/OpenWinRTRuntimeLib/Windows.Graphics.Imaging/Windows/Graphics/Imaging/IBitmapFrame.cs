namespace Windows.Graphics.Imaging
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x72a49a1c, 0x8081, 0x438d, 0x91, 0xbc, 0x94, 0xec, 0xfc, 0x81, 0x85, 0xc6), Version(0x6020000)]
    public interface IBitmapFrame
    {
        [Overload("GetPixelDataAsync"), DefaultOverload]
        IAsyncOperation<PixelDataProvider> GetPixelDataAsync();
        [DefaultOverload, Overload("GetPixelDataTransformedAsync")]
        IAsyncOperation<PixelDataProvider> GetPixelDataAsync([In] Windows.Graphics.Imaging.BitmapPixelFormat pixelFormat, [In] Windows.Graphics.Imaging.BitmapAlphaMode alphaMode, [In] BitmapTransform transform, [In] ExifOrientationMode exifOrientationMode, [In] ColorManagementMode colorManagementMode);
        IAsyncOperation<ImageStream> GetThumbnailAsync();

        Windows.Graphics.Imaging.BitmapAlphaMode BitmapAlphaMode { get; }

        Windows.Graphics.Imaging.BitmapPixelFormat BitmapPixelFormat { get; }

        BitmapPropertiesView BitmapProperties { get; }

        double DpiX { get; }

        double DpiY { get; }

        uint OrientedPixelHeight { get; }

        uint OrientedPixelWidth { get; }

        uint PixelHeight { get; }

        uint PixelWidth { get; }
    }
}

