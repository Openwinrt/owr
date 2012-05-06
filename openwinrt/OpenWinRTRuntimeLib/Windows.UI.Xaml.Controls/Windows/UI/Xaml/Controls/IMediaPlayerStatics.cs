namespace Windows.UI.Xaml.Controls
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [WebHostHidden, Version(0x6020000), ExclusiveTo(typeof(MediaPlayer)), Guid(0x5e18da03, 0x125b, 0x436d, 160, 170, 0xfc, 50, 0x3a, 0x7e, 0xb9, 0xd5)]
    internal interface IMediaPlayerStatics
    {
        DependencyProperty AspectRatioHeightProperty { get; }

        DependencyProperty AspectRatioWidthProperty { get; }

        DependencyProperty AudioCategoryProperty { get; }

        DependencyProperty AudioDeviceTypeProperty { get; }

        DependencyProperty AudioStreamCountProperty { get; }

        DependencyProperty AudioStreamIndexProperty { get; }

        DependencyProperty AutoPlayProperty { get; }

        DependencyProperty BalanceProperty { get; }

        DependencyProperty BufferingProgressProperty { get; }

        DependencyProperty CanPauseProperty { get; }

        DependencyProperty CanSeekProperty { get; }

        DependencyProperty CurrentStateProperty { get; }

        DependencyProperty DefaultPlaybackRateProperty { get; }

        DependencyProperty DownloadProgressOffsetProperty { get; }

        DependencyProperty DownloadProgressProperty { get; }

        DependencyProperty IsLoopingProperty { get; }

        DependencyProperty IsMutedProperty { get; }

        DependencyProperty NaturalDurationProperty { get; }

        DependencyProperty NaturalVideoHeightProperty { get; }

        DependencyProperty NaturalVideoWidthProperty { get; }

        DependencyProperty PlaybackRateProperty { get; }

        DependencyProperty PlayToSourceProperty { get; }

        DependencyProperty PositionProperty { get; }

        DependencyProperty PosterSourceProperty { get; }

        DependencyProperty ProtectionManagerProperty { get; }

        DependencyProperty RealTimePlaybackProperty { get; }

        DependencyProperty SourceProperty { get; }

        DependencyProperty Video3DModeProperty { get; }

        DependencyProperty VolumeProperty { get; }
    }
}

