namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Markup;

    [ContentProperty(Name="Children"), MarshalingBehavior(MarshalingType.FreeThreaded), WebHostHidden, Static(typeof(IStoryboardStatics), 0x6020000), Version(0x6020000), Activatable(0x6020000), Threading(ThreadingModel.Both)]
    public sealed class Storyboard : Timeline, IStoryboard
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Storyboard();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Begin();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ClockState GetCurrentState();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Windows.Foundation.TimeSpan GetCurrentTime();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static string GetTargetName([In] Timeline element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static string GetTargetProperty([In] Timeline element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Pause();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Resume();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Seek([In] Windows.Foundation.TimeSpan offset);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SeekAlignedToLastTick([In] Windows.Foundation.TimeSpan offset);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetTarget([In] Timeline timeline, [In] DependencyObject target);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetTargetName([In] Timeline element, [In] string name);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetTargetProperty([In] Timeline element, [In] string path);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SkipToFill();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Stop();

        public TimelineCollection Children { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty TargetNameProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty TargetPropertyProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public TimelineCollection Windows.UI.Xaml.Media.Animation.IStoryboard.Children { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

