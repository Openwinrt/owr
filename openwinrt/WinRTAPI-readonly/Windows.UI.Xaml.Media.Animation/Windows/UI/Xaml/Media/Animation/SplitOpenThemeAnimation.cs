namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls.Primitives;

    [MarshalingBehavior(MarshalingType.FreeThreaded), WebHostHidden, Threading(ThreadingModel.Both), Version(0x6020000), Static(typeof(ISplitOpenThemeAnimationStatics), 0x6020000), Activatable(0x6020000)]
    public sealed class SplitOpenThemeAnimation : Timeline, ISplitOpenThemeAnimation
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public SplitOpenThemeAnimation();

        public double ClosedLength { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty ClosedLengthProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string ClosedTargetName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty ClosedTargetNameProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string ContentTargetName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty ContentTargetNameProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public AnimationDirection ContentTranslationDirection { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty ContentTranslationDirectionProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double ContentTranslationOffset { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty ContentTranslationOffsetProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double OffsetFromCenter { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty OffsetFromCenterProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double OpenedLength { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty OpenedLengthProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string OpenedTargetName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty OpenedTargetNameProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Media.Animation.ISplitOpenThemeAnimation.ClosedLength { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.UI.Xaml.Media.Animation.ISplitOpenThemeAnimation.ClosedTargetName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.UI.Xaml.Media.Animation.ISplitOpenThemeAnimation.ContentTargetName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public AnimationDirection Windows.UI.Xaml.Media.Animation.ISplitOpenThemeAnimation.ContentTranslationDirection { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public double Windows.UI.Xaml.Media.Animation.ISplitOpenThemeAnimation.ContentTranslationOffset { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public double Windows.UI.Xaml.Media.Animation.ISplitOpenThemeAnimation.OffsetFromCenter { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public double Windows.UI.Xaml.Media.Animation.ISplitOpenThemeAnimation.OpenedLength { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.UI.Xaml.Media.Animation.ISplitOpenThemeAnimation.OpenedTargetName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

