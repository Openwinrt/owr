namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Activatable(0x6020000), Threading(ThreadingModel.Both), MarshalingBehavior(MarshalingType.FreeThreaded), WebHostHidden, Version(0x6020000), Static(typeof(ISplinePointKeyFrameStatics), 0x6020000)]
    public sealed class SplinePointKeyFrame : PointKeyFrame, ISplinePointKeyFrame
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public SplinePointKeyFrame();

        public Windows.UI.Xaml.Media.Animation.KeySpline KeySpline { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty KeySplineProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Media.Animation.KeySpline Windows.UI.Xaml.Media.Animation.ISplinePointKeyFrame.KeySpline { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

