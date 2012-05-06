namespace Windows.Storage.FileProperties
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xbc8aab62, 0x66ec, 0x419a, 0xbc, 0x5d, 0xca, 0x65, 0xa4, 0xcb, 70, 0xda), Version(0x6020000), ExclusiveTo(typeof(MusicProperties))]
    internal interface IMusicProperties : IStorageItemExtraProperties
    {
        string Album { get; [param: In] set; }

        string Artist { get; [param: In] set; }

        uint Bitrate { get; }

        Windows.Foundation.TimeSpan Duration { get; }

        IVector<string> Genre { get; }

        uint Rating { get; [param: In] set; }

        string Title { get; [param: In] set; }

        uint TrackNumber { get; [param: In] set; }
    }
}

