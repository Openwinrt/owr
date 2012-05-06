namespace Windows.UI.Xaml.Controls
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [WebHostHidden, Guid(0x8a4363d7, 0x7fdf, 0x4d30, 0x98, 0xfe, 0xce, 120, 0xc0, 0x5b, 0x31, 0xcf), ExclusiveTo(typeof(Slider)), Version(0x6020000)]
    internal interface ISliderStatics
    {
        DependencyProperty IntermediateValueProperty { get; }

        DependencyProperty IsDirectionReversedProperty { get; }

        DependencyProperty IsThumbToolTipEnabledProperty { get; }

        DependencyProperty OrientationProperty { get; }

        DependencyProperty SnapsToProperty { get; }

        DependencyProperty StepFrequencyProperty { get; }

        DependencyProperty ThumbToolTipValueConverterProperty { get; }

        DependencyProperty TickFrequencyProperty { get; }

        DependencyProperty TickPlacementProperty { get; }
    }
}

