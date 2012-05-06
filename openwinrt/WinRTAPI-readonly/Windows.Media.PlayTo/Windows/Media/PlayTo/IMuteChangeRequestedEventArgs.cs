namespace Windows.Media.PlayTo
{
    using System;
    using Windows.Foundation.Metadata;

    [Guid(0xe4b4f5f6, 0xaf1f, 0x4f1e, 180, 0x37, 0x7d, 0xa3, 0x24, 0, 0xe1, 0xd4), Version(0x6020000), ExclusiveTo(typeof(MuteChangeRequestedEventArgs))]
    internal interface IMuteChangeRequestedEventArgs
    {
        bool Mute { get; }
    }
}

