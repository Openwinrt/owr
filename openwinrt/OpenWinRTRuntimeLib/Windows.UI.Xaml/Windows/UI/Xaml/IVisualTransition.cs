namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Media.Animation;

    [Windows.Foundation.Metadata.Guid(0x55c5905e, 0x2bc7, 0x400d, 170, 0xa4, 0x1a, 0x29, 0x81, 0x49, 30, 0xe0), Version(0x6020000), ExclusiveTo(typeof(VisualTransition)), WebHostHidden]
    internal interface IVisualTransition
    {
        string From { get; [param: In] set; }

        Duration GeneratedDuration { get; [param: In] set; }

        EasingFunctionBase GeneratedEasingFunction { get; [param: In] set; }

        Windows.UI.Xaml.Media.Animation.Storyboard Storyboard { get; [param: In] set; }

        string To { get; [param: In] set; }
    }
}

