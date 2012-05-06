namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls.Primitives;

    [ExclusiveTo(typeof(SplitCloseThemeAnimation)), Version(0x6020000), WebHostHidden, Windows.Foundation.Metadata.Guid(0x4f799518, 0xff39, 0x4e90, 0xbb, 0x74, 0x2a, 0xbd, 0x56, 2, 0x74, 2)]
    internal interface ISplitCloseThemeAnimation
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

