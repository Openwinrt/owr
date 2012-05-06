namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls.Primitives;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x785fd7aa, 0x5456, 0x4639, 0x8f, 210, 0x26, 0xba, 230, 0xa5, 0xff, 0xe4), ExclusiveTo(typeof(SplitOpenThemeAnimation)), WebHostHidden]
    internal interface ISplitOpenThemeAnimation
    {
        double ClosedLength { get; [param: In] set; }

        string ClosedTargetName { get; [param: In] set; }

        string ContentTargetName { get; [param: In] set; }

        AnimationDirection ContentTranslationDirection { get; [param: In] set; }

        double ContentTranslationOffset { get; [param: In] set; }

        double OffsetFromCenter { get; [param: In] set; }

        double OpenedLength { get; [param: In] set; }

        string OpenedTargetName { get; [param: In] set; }
    }
}

