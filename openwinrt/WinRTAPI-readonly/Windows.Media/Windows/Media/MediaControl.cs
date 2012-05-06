namespace Windows.Media
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.MTA), Static(typeof(IMediaControl), 0x6020000)]
    public static class MediaControl
    {
        public static  event Windows.Foundation.EventHandler<object> ChannelDownPressed;

        public static  event Windows.Foundation.EventHandler<object> ChannelUpPressed;

        public static  event Windows.Foundation.EventHandler<object> FastForwardPressed;

        public static  event Windows.Foundation.EventHandler<object> NextTrackPressed;

        public static  event Windows.Foundation.EventHandler<object> PausePressed;

        public static  event Windows.Foundation.EventHandler<object> PlayPauseTogglePressed;

        public static  event Windows.Foundation.EventHandler<object> PlayPressed;

        public static  event Windows.Foundation.EventHandler<object> PreviousTrackPressed;

        public static  event Windows.Foundation.EventHandler<object> RecordPressed;

        public static  event Windows.Foundation.EventHandler<object> RewindPressed;

        public static  event Windows.Foundation.EventHandler<object> SoundLevelChanged;

        public static  event Windows.Foundation.EventHandler<object> StopPressed;

        public static string ArtistName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static bool IsPlaying { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static Windows.Media.SoundLevel SoundLevel { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static string TrackName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

