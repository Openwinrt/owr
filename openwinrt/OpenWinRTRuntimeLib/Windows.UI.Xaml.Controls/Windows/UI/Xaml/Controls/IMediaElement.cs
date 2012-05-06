namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.Media.PlayTo;
    using Windows.Media.Protection;
    using Windows.Storage.Streams;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Media;

    [Version(0x6020000), WebHostHidden, ExclusiveTo(typeof(MediaElement)), Windows.Foundation.Metadata.Guid(0xa38ed2cf, 0x13de, 0x4299, 0xad, 0xe2, 0xae, 0x18, 0xf7, 0x4e, 0xd3, 0x53)]
    internal interface IMediaElement
    {
        event RoutedEventHandler BufferingProgressChanged;

        event RoutedEventHandler CurrentStateChanged;

        event RoutedEventHandler DownloadProgressChanged;

        event TimelineMarkerRoutedEventHandler MarkerReached;

        event RoutedEventHandler MediaEnded;

        event ExceptionRoutedEventHandler MediaFailed;

        event RoutedEventHandler MediaOpened;

        event RateChangedRoutedEventHandler RateChanged;

        event RoutedEventHandler SeekCompleted;

        event RoutedEventHandler VolumeChanged;

        void AddAudioEffect([In] string effectID, [In] bool effectOptional, [In] IPropertySet effectConfiguration);
        void AddVideoEffect([In] string effectID, [In] bool effectOptional, [In] IPropertySet effectConfiguration);
        MediaCanPlayResponse CanPlayType([In] string type);
        string GetAudioStreamLanguage([In] IReference<int> index);
        void Pause();
        void Play();
        void RemoveAllEffects();
        void SetSource([In] IRandomAccessStream stream, [In] string mimeType);
        void Stop();

        int AspectRatioHeight { get; }

        int AspectRatioWidth { get; }

        Windows.UI.Xaml.Media.AudioCategory AudioCategory { get; [param: In] set; }

        Windows.UI.Xaml.Media.AudioDeviceType AudioDeviceType { get; [param: In] set; }

        int AudioStreamCount { get; }

        IReference<int> AudioStreamIndex { get; [param: In] set; }

        bool AutoPlay { get; [param: In] set; }

        double Balance { get; [param: In] set; }

        double BufferingProgress { get; }

        bool CanPause { get; }

        bool CanSeek { get; }

        MediaElementState CurrentState { get; }

        double DefaultPlaybackRate { get; [param: In] set; }

        double DownloadProgress { get; }

        double DownloadProgressOffset { get; }

        bool IsLooping { get; [param: In] set; }

        bool IsMuted { get; [param: In] set; }

        TimelineMarkerCollection Markers { get; }

        Duration NaturalDuration { get; }

        int NaturalVideoHeight { get; }

        int NaturalVideoWidth { get; }

        double PlaybackRate { get; [param: In] set; }

        Windows.Media.PlayTo.PlayToSource PlayToSource { get; }

        Windows.Foundation.TimeSpan Position { get; [param: In] set; }

        ImageSource PosterSource { get; [param: In] set; }

        MediaProtectionManager ProtectionManager { get; [param: In] set; }

        bool RealTimePlayback { get; [param: In] set; }

        Uri Source { get; [param: In] set; }

        Windows.UI.Xaml.Media.Video3DMode Video3DMode { get; [param: In] set; }

        double Volume { get; [param: In] set; }
    }
}

