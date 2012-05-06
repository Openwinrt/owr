namespace Windows.Media.MediaProperties
{
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(ImageEncodingProperties)), Guid(0x257c68dc, 0x8b99, 0x439e, 170, 0x59, 0x91, 0x3a, 0x36, 0x16, 0x12, 0x97)]
    internal interface IImageEncodingPropertiesStatics
    {
        ImageEncodingProperties CreateJpeg();
        ImageEncodingProperties CreateJpegXR();
        ImageEncodingProperties CreatePng();
    }
}

