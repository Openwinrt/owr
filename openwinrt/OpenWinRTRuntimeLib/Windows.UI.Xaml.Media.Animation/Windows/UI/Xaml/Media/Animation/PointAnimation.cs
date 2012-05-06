namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Activatable(0x6020000), Threading(ThreadingModel.Both), Version(0x6020000), WebHostHidden, Static(typeof(IPointAnimationStatics), 0x6020000)]
    public sealed class PointAnimation : Timeline, IPointAnimation
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public PointAnimation();

        public IReference<Point> By { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty ByProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public EasingFunctionBase EasingFunction { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty EasingFunctionProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool EnableDependentAnimation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty EnableDependentAnimationProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IReference<Point> From { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty FromProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IReference<Point> To { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty ToProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IReference<Point> Windows.UI.Xaml.Media.Animation.IPointAnimation.By { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public EasingFunctionBase Windows.UI.Xaml.Media.Animation.IPointAnimation.EasingFunction { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.UI.Xaml.Media.Animation.IPointAnimation.EnableDependentAnimation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IReference<Point> Windows.UI.Xaml.Media.Animation.IPointAnimation.From { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IReference<Point> Windows.UI.Xaml.Media.Animation.IPointAnimation.To { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

