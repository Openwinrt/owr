namespace Windows.Storage.FileProperties
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(VideoProperties)), Windows.Foundation.Metadata.Guid(0x719ae507, 0x68de, 0x4db8, 0x97, 0xde, 0x49, 0x99, 140, 5, 0x9f, 0x2f)]
    internal interface IVideoProperties : IStorageItemExtraProperties
    {
        Windows.Foundation.TimeSpan Duration { get; }

        uint Height { get; }

        IVector<string> Keywords { get; }

        uint Rating { get; [param: In] set; }

        uint Width { get; }
    }
}

