namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [WebHostHidden, ExclusiveTo(typeof(Timeline)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0xbc465dc, 0xbe4d, 0x4d0d, 0x95, 0x49, 0x22, 8, 0xb7, 0x15, 0xf4, 13)]
    internal interface ITimeline
    {
        event Windows.Foundation.EventHandler<object> Completed;

        bool AutoReverse { get; [param: In] set; }

        IReference<Windows.Foundation.TimeSpan> BeginTime { get; [param: In] set; }

        Windows.UI.Xaml.Duration Duration { get; [param: In] set; }

        Windows.UI.Xaml.Media.Animation.FillBehavior FillBehavior { get; [param: In] set; }

        Windows.UI.Xaml.Media.Animation.RepeatBehavior RepeatBehavior { get; [param: In] set; }

        double SpeedRatio { get; [param: In] set; }
    }
}

