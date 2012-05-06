namespace Windows.Graphics.Imaging
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(BitmapEncoder)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0x2bc468e3, 0xe1f8, 0x4b54, 0x95, 0xe8, 50, 0x91, 0x95, 0x51, 0xce, 0x62)]
    internal interface IBitmapEncoder
    {
        IAsyncAction FlushAsync();
        [Overload("GoToNextFrameAsync"), DefaultOverload]
        IAsyncAction GoToNextFrameAsync();
        [Overload("GoToNextFrameWithEncodingOptionsAsync"), DefaultOverload]
        IAsyncAction GoToNextFrameAsync([In] IIterable<IKeyValuePair<string, BitmapTypedValue>> encodingOptions);
        void SetPixelData([In] BitmapPixelFormat pixelFormat, [In] BitmapAlphaMode alphaMode, [In] uint width, [In] uint height, [In] double dpiX, [In] double dpiY, [In, Range(0, 0x7fffffff)] byte[] pixels);

        Windows.Graphics.Imaging.BitmapProperties BitmapContainerProperties { get; }

        Windows.Graphics.Imaging.BitmapProperties BitmapProperties { get; }

        Windows.Graphics.Imaging.BitmapTransform BitmapTransform { get; }

        BitmapCodecInformation EncoderInformation { get; }

        uint GeneratedThumbnailHeight { get; [param: In] set; }

        uint GeneratedThumbnailWidth { get; [param: In] set; }

        bool IsThumbnailGenerated { get; [param: In] set; }
    }
}

