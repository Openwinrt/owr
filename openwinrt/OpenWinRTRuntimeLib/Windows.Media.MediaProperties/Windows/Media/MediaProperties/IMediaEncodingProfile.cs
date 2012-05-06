namespace Windows.Media.MediaProperties
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xe7dbf5a8, 0x1db9, 0x4783, 0x87, 0x6b, 0x3d, 0xfe, 0x12, 0xac, 0xfd, 0xb3), Version(0x6020000), ExclusiveTo(typeof(MediaEncodingProfile))]
    internal interface IMediaEncodingProfile
    {
        AudioEncodingProperties Audio { get; [param: In] set; }

        ContainerEncodingProperties Container { get; [param: In] set; }

        VideoEncodingProperties Video { get; [param: In] set; }
    }
}

