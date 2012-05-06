namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Activatable(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Static(typeof(IPopInThemeAnimationStatics), 0x6020000), Version(0x6020000), Threading(ThreadingModel.Both), WebHostHidden]
    public sealed class PopInThemeAnimation : Timeline, IPopInThemeAnimation
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public PopInThemeAnimation();

        public double FromHorizontalOffset { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty FromHorizontalOffsetProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double FromVerticalOffset { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty FromVerticalOffsetProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string TargetName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty TargetNameProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Media.Animation.IPopInThemeAnimation.FromHorizontalOffset { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public double Windows.UI.Xaml.Media.Animation.IPopInThemeAnimation.FromVerticalOffset { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.UI.Xaml.Media.Animation.IPopInThemeAnimation.TargetName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

