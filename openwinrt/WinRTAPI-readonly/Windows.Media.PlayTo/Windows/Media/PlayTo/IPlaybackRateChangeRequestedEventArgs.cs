namespace Windows.Media.PlayTo
{
    using System;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(PlaybackRateChangeRequestedEventArgs)), Guid(0xf5661ae, 0x2c88, 0x4cca, 0x85, 0x40, 0xd5, 0x86, 9, 0x5d, 0x13, 0xa5), Version(0x6020000)]
    internal interface IPlaybackRateChangeRequestedEventArgs
    {
        double Rate { get; }
    }
}

