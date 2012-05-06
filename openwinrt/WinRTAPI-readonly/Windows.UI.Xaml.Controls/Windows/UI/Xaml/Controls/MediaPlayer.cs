namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.Media.PlayTo;
    using Windows.Media.Protection;
    using Windows.Storage.Streams;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Media;

    [Version(0x6020000), Threading(ThreadingModel.Both), MarshalingBehavior(MarshalingType.FreeThreaded), WebHostHidden, Static(typeof(IMediaPlayerStatics), 0x6020000), Composable(typeof(IMediaPlayerFactory), CompositionType.Public, 0x6020000)]
    public class MediaPlayer : Control, IMediaPlayer
    {
        public event RoutedEventHandler BufferingProgressChanged;

        public event RoutedEventHandler CurrentStateChanged;

        public event RoutedEventHandler DownloadProgressChanged;

        public event TimelineMarkerRoutedEventHandler MarkerReached;

        public event RoutedEventHandler MediaEnded;

        public event ExceptionRoutedEventHandler MediaFailed;

        public event RoutedEventHandler MediaOpened;

        public event RateChangedRoutedEventHandler RateChanged;

        public event RoutedEventHandler SeekCompleted;

        public event RoutedEventHandler VolumeChanged;

        public event RoutedEventHandler Windows.UI.Xaml.Controls.IMediaPlayer.BufferingProgressChanged;

        public event RoutedEventHandler Windows.UI.Xaml.Controls.IMediaPlayer.CurrentStateChanged;

        public event RoutedEventHandler Windows.UI.Xaml.Controls.IMediaPlayer.DownloadProgressChanged;

        public event TimelineMarkerRoutedEventHandler Windows.UI.Xaml.Controls.IMediaPlayer.MarkerReached;

        public event RoutedEventHandler Windows.UI.Xaml.Controls.IMediaPlayer.MediaEnded;

        public event ExceptionRoutedEventHandler Windows.UI.Xaml.Controls.IMediaPlayer.MediaFailed;

        public event RoutedEventHandler Windows.UI.Xaml.Controls.IMediaPlayer.MediaOpened;

        public event RateChangedRoutedEventHandler Windows.UI.Xaml.Controls.IMediaPlayer.RateChanged;

        public event RoutedEventHandler Windows.UI.Xaml.Controls.IMediaPlayer.SeekCompleted;

        public event RoutedEventHandler Windows.UI.Xaml.Controls.IMediaPlayer.VolumeChanged;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public MediaPlayer();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void AddAudioEffect([In] string effectID, [In] bool effectOptional, [In] IPropertySet effectConfiguration);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void AddVideoEffect([In] string effectID, [In] bool effectOptional, [In] IPropertySet effectConfiguration);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public MediaCanPlayResponse CanPlayType([In] string type);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public string GetAudioStreamLanguage([In] IReference<int> index);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Pause();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Play();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void RemoveAllEffects();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SetSource([In] IRandomAccessStream stream, [In] string mimeType);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Stop();

        public int AspectRatioHeight { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty AspectRatioHeightProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int AspectRatioWidth { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty AspectRatioWidthProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Media.AudioCategory AudioCategory { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty AudioCategoryProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Media.AudioDeviceType AudioDeviceType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty AudioDeviceTypeProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int AudioStreamCount { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty AudioStreamCountProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IReference<int> AudioStreamIndex { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty AudioStreamIndexProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool AutoPlay { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty AutoPlayProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Balance { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty BalanceProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double BufferingProgress { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty BufferingProgressProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool CanPause { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty CanPauseProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool CanSeek { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty CanSeekProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public MediaElementState CurrentState { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty CurrentStateProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double DefaultPlaybackRate { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty DefaultPlaybackRateProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double DownloadProgress { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double DownloadProgressOffset { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty DownloadProgressOffsetProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty DownloadProgressProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool IsLooping { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty IsLoopingProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool IsMuted { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty IsMutedProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public TimelineMarkerCollection Markers { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Duration NaturalDuration { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty NaturalDurationProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int NaturalVideoHeight { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty NaturalVideoHeightProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int NaturalVideoWidth { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty NaturalVideoWidthProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double PlaybackRate { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty PlaybackRateProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Media.PlayTo.PlayToSource PlayToSource { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty PlayToSourceProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.TimeSpan Position { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty PositionProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ImageSource PosterSource { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty PosterSourceProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public MediaProtectionManager ProtectionManager { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty ProtectionManagerProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool RealTimePlayback { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty RealTimePlaybackProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Uri Source { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty SourceProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Media.Video3DMode Video3DMode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty Video3DModeProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Volume { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty VolumeProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int Windows.UI.Xaml.Controls.IMediaPlayer.AspectRatioHeight { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int Windows.UI.Xaml.Controls.IMediaPlayer.AspectRatioWidth { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Media.AudioCategory Windows.UI.Xaml.Controls.IMediaPlayer.AudioCategory { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.UI.Xaml.Media.AudioDeviceType Windows.UI.Xaml.Controls.IMediaPlayer.AudioDeviceType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public int Windows.UI.Xaml.Controls.IMediaPlayer.AudioStreamCount { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IReference<int> Windows.UI.Xaml.Controls.IMediaPlayer.AudioStreamIndex { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.UI.Xaml.Controls.IMediaPlayer.AutoPlay { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public double Windows.UI.Xaml.Controls.IMediaPlayer.Balance { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public double Windows.UI.Xaml.Controls.IMediaPlayer.BufferingProgress { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Xaml.Controls.IMediaPlayer.CanPause { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Xaml.Controls.IMediaPlayer.CanSeek { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public MediaElementState Windows.UI.Xaml.Controls.IMediaPlayer.CurrentState { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Controls.IMediaPlayer.DefaultPlaybackRate { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public double Windows.UI.Xaml.Controls.IMediaPlayer.DownloadProgress { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Controls.IMediaPlayer.DownloadProgressOffset { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Xaml.Controls.IMediaPlayer.IsLooping { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.UI.Xaml.Controls.IMediaPlayer.IsMuted { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public TimelineMarkerCollection Windows.UI.Xaml.Controls.IMediaPlayer.Markers { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Duration Windows.UI.Xaml.Controls.IMediaPlayer.NaturalDuration { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int Windows.UI.Xaml.Controls.IMediaPlayer.NaturalVideoHeight { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int Windows.UI.Xaml.Controls.IMediaPlayer.NaturalVideoWidth { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Controls.IMediaPlayer.PlaybackRate { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.Media.PlayTo.PlayToSource Windows.UI.Xaml.Controls.IMediaPlayer.PlayToSource { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.TimeSpan Windows.UI.Xaml.Controls.IMediaPlayer.Position { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public ImageSource Windows.UI.Xaml.Controls.IMediaPlayer.PosterSource { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public MediaProtectionManager Windows.UI.Xaml.Controls.IMediaPlayer.ProtectionManager { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.UI.Xaml.Controls.IMediaPlayer.RealTimePlayback { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Uri Windows.UI.Xaml.Controls.IMediaPlayer.Source { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.UI.Xaml.Media.Video3DMode Windows.UI.Xaml.Controls.IMediaPlayer.Video3DMode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public double Windows.UI.Xaml.Controls.IMediaPlayer.Volume { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

