namespace Windows.Media
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(MediaControl)), Windows.Foundation.Metadata.Guid(0x98f1fbe1, 0x7a8d, 0x42cb, 0xb6, 0xfe, 0x8f, 230, 0x98, 0x26, 0x4f, 0x13)]
    internal interface IMediaControl
    {
        event Windows.Foundation.EventHandler<object> ChannelDownPressed;

        event Windows.Foundation.EventHandler<object> ChannelUpPressed;

        event Windows.Foundation.EventHandler<object> FastForwardPressed;

        event Windows.Foundation.EventHandler<object> NextTrackPressed;

        event Windows.Foundation.EventHandler<object> PausePressed;

        event Windows.Foundation.EventHandler<object> PlayPauseTogglePressed;

        event Windows.Foundation.EventHandler<object> PlayPressed;

        event Windows.Foundation.EventHandler<object> PreviousTrackPressed;

        event Windows.Foundation.EventHandler<object> RecordPressed;

        event Windows.Foundation.EventHandler<object> RewindPressed;

        event Windows.Foundation.EventHandler<object> SoundLevelChanged;

        event Windows.Foundation.EventHandler<object> StopPressed;

        string ArtistName { get; [param: In] set; }

        bool IsPlaying { get; [param: In] set; }

        Windows.Media.SoundLevel SoundLevel { get; }

        string TrackName { get; [param: In] set; }
    }
}

