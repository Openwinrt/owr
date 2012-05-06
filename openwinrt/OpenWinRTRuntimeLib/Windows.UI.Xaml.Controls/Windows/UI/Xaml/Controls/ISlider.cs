namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls.Primitives;
    using Windows.UI.Xaml.Data;

    [Version(0x6020000), WebHostHidden, Windows.Foundation.Metadata.Guid(0x89572027, 0x4c48, 0x4700, 0x80, 0x76, 0x49, 0x7b, 0xa7, 0x3d, 0x9c, 0x18), ExclusiveTo(typeof(Slider))]
    internal interface ISlider
    {
        double IntermediateValue { get; [param: In] set; }

        bool IsDirectionReversed { get; [param: In] set; }

        bool IsThumbToolTipEnabled { get; [param: In] set; }

        Windows.UI.Xaml.Controls.Orientation Orientation { get; [param: In] set; }

        SliderSnapsTo SnapsTo { get; [param: In] set; }

        double StepFrequency { get; [param: In] set; }

        IValueConverter ThumbToolTipValueConverter { get; [param: In] set; }

        double TickFrequency { get; [param: In] set; }

        Windows.UI.Xaml.Controls.Primitives.TickPlacement TickPlacement { get; [param: In] set; }
    }
}

