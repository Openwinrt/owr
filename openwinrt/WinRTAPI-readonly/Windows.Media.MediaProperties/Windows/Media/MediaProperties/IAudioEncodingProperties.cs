namespace Windows.Media.MediaProperties
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(AudioEncodingProperties)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0x62bc7a16, 0x5c, 0x4b3b, 0x8a, 11, 10, 9, 14, 150, 0x87, 0xf3)]
    internal interface IAudioEncodingProperties : IMediaEncodingProperties
    {
        uint Bitrate { get; [param: In] set; }

        uint BitsPerSample { get; [param: In] set; }

        uint ChannelCount { get; [param: In] set; }

        uint SampleRate { get; [param: In] set; }
    }
}

