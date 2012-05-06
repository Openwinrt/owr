namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Threading(ThreadingModel.Both), Activatable(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Static(typeof(IEasingColorKeyFrameStatics), 0x6020000), WebHostHidden, Version(0x6020000)]
    public sealed class EasingColorKeyFrame : ColorKeyFrame, IEasingColorKeyFrame
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public EasingColorKeyFrame();

        public EasingFunctionBase EasingFunction { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty EasingFunctionProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public EasingFunctionBase Windows.UI.Xaml.Media.Animation.IEasingColorKeyFrame.EasingFunction { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

