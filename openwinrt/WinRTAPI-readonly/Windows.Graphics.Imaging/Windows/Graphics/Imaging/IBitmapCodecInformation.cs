namespace Windows.Graphics.Imaging
{
    using System;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(BitmapCodecInformation)), Guid(0x400caaf2, 0xc4b0, 0x4392, 0xa3, 0xb0, 0x6f, 0x6f, 0x9b, 0xa9, 0x5c, 180)]
    internal interface IBitmapCodecInformation
    {
        Guid CodecId { get; }

        IVectorView<string> FileExtensions { get; }

        string FriendlyName { get; }

        IVectorView<string> MimeTypes { get; }
    }
}

