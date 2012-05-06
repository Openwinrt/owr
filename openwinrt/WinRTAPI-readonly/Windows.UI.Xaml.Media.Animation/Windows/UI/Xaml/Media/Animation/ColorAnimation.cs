namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [WebHostHidden, MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both), Version(0x6020000), Activatable(0x6020000), Static(typeof(IColorAnimationStatics), 0x6020000)]
    public sealed class ColorAnimation : Timeline, IColorAnimation
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ColorAnimation();

        public IReference<Color> By { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty ByProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public EasingFunctionBase EasingFunction { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty EasingFunctionProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool EnableDependentAnimation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty EnableDependentAnimationProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IReference<Color> From { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty FromProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IReference<Color> To { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty ToProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IReference<Color> Windows.UI.Xaml.Media.Animation.IColorAnimation.By { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public EasingFunctionBase Windows.UI.Xaml.Media.Animation.IColorAnimation.EasingFunction { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.UI.Xaml.Media.Animation.IColorAnimation.EnableDependentAnimation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IReference<Color> Windows.UI.Xaml.Media.Animation.IColorAnimation.From { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IReference<Color> Windows.UI.Xaml.Media.Animation.IColorAnimation.To { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

