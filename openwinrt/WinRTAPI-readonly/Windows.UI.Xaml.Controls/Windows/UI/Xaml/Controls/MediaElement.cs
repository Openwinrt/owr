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

    [Threading(ThreadingModel.Both), MarshalingBehavior(MarshalingType.FreeThreaded), Activatable(0x6020000), WebHostHidden, Version(0x6020000), Static(typeof(IMediaElementStatics), 0x6020000)]
    public sealed class MediaElement : FrameworkElement, IMediaElement
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

        public event RoutedEventHandler Windows.UI.Xaml.Controls.IMediaElement.BufferingProgressChanged;

        public event RoutedEventHandler Windows.UI.Xaml.Controls.IMediaElement.CurrentStateChanged;

        public event RoutedEventHandler Windows.UI.Xaml.Controls.IMediaElement.DownloadProgressChanged;

        public event TimelineMarkerRoutedEventHandler Windows.UI.Xaml.Controls.IMediaElement.MarkerReached;

        public event RoutedEventHandler Windows.UI.Xaml.Controls.IMediaElement.MediaEnded;

        public event ExceptionRoutedEventHandler Windows.UI.Xaml.Controls.IMediaElement.MediaFailed;

        public event RoutedEventHandler Windows.UI.Xaml.Controls.IMediaElement.MediaOpened;

        public event RateChangedRoutedEventHandler Windows.UI.Xaml.Controls.IMediaElement.RateChanged;

        public event RoutedEventHandler Windows.UI.Xaml.Controls.IMediaElement.SeekCompleted;

        public event RoutedEventHandler Windows.UI.Xaml.Controls.IMediaElement.VolumeChanged;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public MediaElement();
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

        public int Windows.UI.Xaml.Controls.IMediaElement.AspectRatioHeight { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int Windows.UI.Xaml.Controls.IMediaElement.AspectRatioWidth { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Media.AudioCategory Windows.UI.Xaml.Controls.IMediaElement.AudioCategory { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.UI.Xaml.Media.AudioDeviceType Windows.UI.Xaml.Controls.IMediaElement.AudioDeviceType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public int Windows.UI.Xaml.Controls.IMediaElement.AudioStreamCount { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IReference<int> Windows.UI.Xaml.Controls.IMediaElement.AudioStreamIndex { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.UI.Xaml.Controls.IMediaElement.AutoPlay { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public double Windows.UI.Xaml.Controls.IMediaElement.Balance { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public double Windows.UI.Xaml.Controls.IMediaElement.BufferingProgress { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Xaml.Controls.IMediaElement.CanPause { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Xaml.Controls.IMediaElement.CanSeek { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public MediaElementState Windows.UI.Xaml.Controls.IMediaElement.CurrentState { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Controls.IMediaElement.DefaultPlaybackRate { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public double Windows.UI.Xaml.Controls.IMediaElement.DownloadProgress { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Controls.IMediaElement.DownloadProgressOffset { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Xaml.Controls.IMediaElement.IsLooping { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.UI.Xaml.Controls.IMediaElement.IsMuted { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public TimelineMarkerCollection Windows.UI.Xaml.Controls.IMediaElement.Markers { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Duration Windows.UI.Xaml.Controls.IMediaElement.NaturalDuration { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int Windows.UI.Xaml.Controls.IMediaElement.NaturalVideoHeight { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int Windows.UI.Xaml.Controls.IMediaElement.NaturalVideoWidth { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Controls.IMediaElement.PlaybackRate { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.Media.PlayTo.PlayToSource Windows.UI.Xaml.Controls.IMediaElement.PlayToSource { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.TimeSpan Windows.UI.Xaml.Controls.IMediaElement.Position { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public ImageSource Windows.UI.Xaml.Controls.IMediaElement.PosterSource { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public MediaProtectionManager Windows.UI.Xaml.Controls.IMediaElement.ProtectionManager { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.UI.Xaml.Controls.IMediaElement.RealTimePlayback { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Uri Windows.UI.Xaml.Controls.IMediaElement.Source { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.UI.Xaml.Media.Video3DMode Windows.UI.Xaml.Controls.IMediaElement.Video3DMode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public double Windows.UI.Xaml.Controls.IMediaElement.Volume { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

