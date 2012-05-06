namespace Windows.UI.Xaml.Controls
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [ExclusiveTo(typeof(MediaElement)), Guid(0xdccd2cb9, 0x7568, 0x4682, 0xa7, 0x2a, 0x8d, 0xdf, 0x2a, 0x26, 0x65, 0xca), WebHostHidden, Version(0x6020000)]
    internal interface IMediaElementStatics
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

