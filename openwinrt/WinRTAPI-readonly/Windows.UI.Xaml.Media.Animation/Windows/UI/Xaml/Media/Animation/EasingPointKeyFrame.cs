namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Static(typeof(IEasingPointKeyFrameStatics), 0x6020000), Activatable(0x6020000), Version(0x6020000), Threading(ThreadingModel.Both), WebHostHidden, MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class EasingPointKeyFrame : PointKeyFrame, IEasingPointKeyFrame
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public EasingPointKeyFrame();

        public EasingFunctionBase EasingFunction { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty EasingFunctionProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public EasingFunctionBase Windows.UI.Xaml.Media.Animation.IEasingPointKeyFrame.EasingFunction { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

