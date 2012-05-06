namespace Windows.Media.PlayTo
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Activatable(0x6020000), Threading(ThreadingModel.Both), Version(0x6020000)]
    public sealed class PlayToReceiver : IPlayToReceiver
    {
        public event TypedEventHandler<PlayToReceiver, CurrentTimeChangeRequestedEventArgs> CurrentTimeChangeRequested;

        public event TypedEventHandler<PlayToReceiver, MuteChangeRequestedEventArgs> MuteChangeRequested;

        public event TypedEventHandler<PlayToReceiver, object> PauseRequested;

        public event TypedEventHandler<PlayToReceiver, PlaybackRateChangeRequestedEventArgs> PlaybackRateChangeRequested;

        public event TypedEventHandler<PlayToReceiver, object> PlayRequested;

        public event TypedEventHandler<PlayToReceiver, SourceChangeRequestedEventArgs> SourceChangeRequested;

        public event TypedEventHandler<PlayToReceiver, object> StopRequested;

        public event TypedEventHandler<PlayToReceiver, object> TimeUpdateRequested;

        public event TypedEventHandler<PlayToReceiver, VolumeChangeRequestedEventArgs> VolumeChangeRequested;

        public event TypedEventHandler<PlayToReceiver, CurrentTimeChangeRequestedEventArgs> Windows.Media.PlayTo.IPlayToReceiver.CurrentTimeChangeRequested;

        public event TypedEventHandler<PlayToReceiver, MuteChangeRequestedEventArgs> Windows.Media.PlayTo.IPlayToReceiver.MuteChangeRequested;

        public event TypedEventHandler<PlayToReceiver, object> Windows.Media.PlayTo.IPlayToReceiver.PauseRequested;

        public event TypedEventHandler<PlayToReceiver, PlaybackRateChangeRequestedEventArgs> Windows.Media.PlayTo.IPlayToReceiver.PlaybackRateChangeRequested;

        public event TypedEventHandler<PlayToReceiver, object> Windows.Media.PlayTo.IPlayToReceiver.PlayRequested;

        public event TypedEventHandler<PlayToReceiver, SourceChangeRequestedEventArgs> Windows.Media.PlayTo.IPlayToReceiver.SourceChangeRequested;

        public event TypedEventHandler<PlayToReceiver, object> Windows.Media.PlayTo.IPlayToReceiver.StopRequested;

        public event TypedEventHandler<PlayToReceiver, object> Windows.Media.PlayTo.IPlayToReceiver.TimeUpdateRequested;

        public event TypedEventHandler<PlayToReceiver, VolumeChangeRequestedEventArgs> Windows.Media.PlayTo.IPlayToReceiver.VolumeChangeRequested;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public PlayToReceiver();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void NotifyDurationChange([In] Windows.Foundation.TimeSpan duration);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void NotifyEnded();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void NotifyError();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void NotifyLoadedMetadata();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void NotifyPaused();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void NotifyPlaying();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void NotifyRateChange([In] double rate);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void NotifySeeked();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void NotifySeeking();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void NotifyStopped();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void NotifyTimeUpdate([In] Windows.Foundation.TimeSpan currentTime);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void NotifyVolumeChange([In] double volume, [In] bool mute);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncAction StartAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncAction StopAsync();

        public string FriendlyName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IPropertySet Properties { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool SupportsAudio { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool SupportsImage { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool SupportsVideo { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.Media.PlayTo.IPlayToReceiver.FriendlyName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IPropertySet Windows.Media.PlayTo.IPlayToReceiver.Properties { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.Media.PlayTo.IPlayToReceiver.SupportsAudio { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.Media.PlayTo.IPlayToReceiver.SupportsImage { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.Media.PlayTo.IPlayToReceiver.SupportsVideo { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

