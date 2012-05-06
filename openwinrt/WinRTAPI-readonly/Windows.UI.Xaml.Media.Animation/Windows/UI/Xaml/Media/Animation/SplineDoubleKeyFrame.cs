namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Version(0x6020000), Static(typeof(ISplineDoubleKeyFrameStatics), 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both), WebHostHidden, Activatable(0x6020000)]
    public sealed class SplineDoubleKeyFrame : DoubleKeyFrame, ISplineDoubleKeyFrame
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public SplineDoubleKeyFrame();

        public Windows.UI.Xaml.Media.Animation.KeySpline KeySpline { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty KeySplineProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Media.Animation.KeySpline Windows.UI.Xaml.Media.Animation.ISplineDoubleKeyFrame.KeySpline { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

