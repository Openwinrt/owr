namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Static(typeof(IEasingDoubleKeyFrameStatics), 0x6020000), WebHostHidden, Version(0x6020000), Activatable(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both)]
    public sealed class EasingDoubleKeyFrame : DoubleKeyFrame, IEasingDoubleKeyFrame
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public EasingDoubleKeyFrame();

        public EasingFunctionBase EasingFunction { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty EasingFunctionProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public EasingFunctionBase Windows.UI.Xaml.Media.Animation.IEasingDoubleKeyFrame.EasingFunction { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

