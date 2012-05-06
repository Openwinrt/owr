namespace Windows.Graphics.Imaging
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0xacef22ba, 0x1d74, 0x4c91, 0x9d, 0xfc, 150, 0x20, 0x74, 0x52, 0x33, 230), ExclusiveTo(typeof(BitmapDecoder))]
    internal interface IBitmapDecoder
    {
        IAsyncOperation<BitmapFrame> GetFrameAsync([In] uint frameIndex);
        IAsyncOperation<ImageStream> GetPreviewAsync();

        BitmapPropertiesView BitmapContainerProperties { get; }

        BitmapCodecInformation DecoderInformation { get; }

        uint FrameCount { get; }
    }
}

