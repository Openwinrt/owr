namespace Windows.Media.PlayTo
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0xac15cf47, 0xa162, 0x4aa6, 0xaf, 0x1b, 0x3a, 0xa3, 0x5f, 0x3b, 0x90, 0x69), ExclusiveTo(typeof(PlayToReceiver))]
    internal interface IPlayToReceiver
    {
        event TypedEventHandler<PlayToReceiver, CurrentTimeChangeRequestedEventArgs> CurrentTimeChangeRequested;

        event TypedEventHandler<PlayToReceiver, MuteChangeRequestedEventArgs> MuteChangeRequested;

        event TypedEventHandler<PlayToReceiver, object> PauseRequested;

        event TypedEventHandler<PlayToReceiver, PlaybackRateChangeRequestedEventArgs> PlaybackRateChangeRequested;

        event TypedEventHandler<PlayToReceiver, object> PlayRequested;

        event TypedEventHandler<PlayToReceiver, SourceChangeRequestedEventArgs> SourceChangeRequested;

        event TypedEventHandler<PlayToReceiver, object> StopRequested;

        event TypedEventHandler<PlayToReceiver, object> TimeUpdateRequested;

        event TypedEventHandler<PlayToReceiver, VolumeChangeRequestedEventArgs> VolumeChangeRequested;

        void NotifyDurationChange([In] Windows.Foundation.TimeSpan duration);
        void NotifyEnded();
        void NotifyError();
        void NotifyLoadedMetadata();
        void NotifyPaused();
        void NotifyPlaying();
        void NotifyRateChange([In] double rate);
        void NotifySeeked();
        void NotifySeeking();
        void NotifyStopped();
        void NotifyTimeUpdate([In] Windows.Foundation.TimeSpan currentTime);
        void NotifyVolumeChange([In] double volume, [In] bool mute);
        IAsyncAction StartAsync();
        IAsyncAction StopAsync();

        string FriendlyName { get; [param: In] set; }

        IPropertySet Properties { get; }

        bool SupportsAudio { get; [param: In] set; }

        bool SupportsImage { get; [param: In] set; }

        bool SupportsVideo { get; [param: In] set; }
    }
}

