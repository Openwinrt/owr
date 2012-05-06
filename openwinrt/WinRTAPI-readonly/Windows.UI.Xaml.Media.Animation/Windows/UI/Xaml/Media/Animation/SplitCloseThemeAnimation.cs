namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls.Primitives;

    [Static(typeof(ISplitCloseThemeAnimationStatics), 0x6020000), Threading(ThreadingModel.Both), WebHostHidden, MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000), Activatable(0x6020000)]
    public sealed class SplitCloseThemeAnimation : Timeline, ISplitCloseThemeAnimation
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public SplitCloseThemeAnimation();

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

        public double Windows.UI.Xaml.Media.Animation.ISplitCloseThemeAnimation.ClosedLength { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.UI.Xaml.Media.Animation.ISplitCloseThemeAnimation.ClosedTargetName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.UI.Xaml.Media.Animation.ISplitCloseThemeAnimation.ContentTargetName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public AnimationDirection Windows.UI.Xaml.Media.Animation.ISplitCloseThemeAnimation.ContentTranslationDirection { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public double Windows.UI.Xaml.Media.Animation.ISplitCloseThemeAnimation.ContentTranslationOffset { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public double Windows.UI.Xaml.Media.Animation.ISplitCloseThemeAnimation.OffsetFromCenter { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public double Windows.UI.Xaml.Media.Animation.ISplitCloseThemeAnimation.OpenedLength { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.UI.Xaml.Media.Animation.ISplitCloseThemeAnimation.OpenedTargetName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

