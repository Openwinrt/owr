namespace Windows.Media.MediaProperties
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xb4002af6, 0xacd4, 0x4e5a, 0xa2, 0x4b, 0x5d, 0x74, 0x98, 0xa8, 0xb8, 0xc4), Version(0x6020000)]
    public interface IMediaEncodingProperties
    {
        MediaPropertySet Properties { get; }

        string Subtype { get; [param: In] set; }

        string Type { get; }
    }
}

