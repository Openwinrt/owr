namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xd45c1e6e, 0x3594, 0x460e, 0x98, 0x1a, 50, 0x27, 0x1b, 0xd3, 170, 6), WebHostHidden, Version(0x6020000), ExclusiveTo(typeof(Storyboard))]
    internal interface IStoryboard
    {
        void Begin();
        ClockState GetCurrentState();
        Windows.Foundation.TimeSpan GetCurrentTime();
        void Pause();
        void Resume();
        void Seek([In] Windows.Foundation.TimeSpan offset);
        void SeekAlignedToLastTick([In] Windows.Foundation.TimeSpan offset);
        void SkipToFill();
        void Stop();

        TimelineCollection Children { get; }
    }
}

