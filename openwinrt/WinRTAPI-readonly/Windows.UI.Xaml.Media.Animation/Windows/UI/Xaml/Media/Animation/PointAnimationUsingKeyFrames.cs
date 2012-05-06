namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Markup;

    [MarshalingBehavior(MarshalingType.FreeThreaded), ContentProperty(Name="KeyFrames"), Static(typeof(IPointAnimationUsingKeyFramesStatics), 0x6020000), WebHostHidden, Activatable(0x6020000), Version(0x6020000), Threading(ThreadingModel.Both)]
    public sealed class PointAnimationUsingKeyFrames : Timeline, IPointAnimationUsingKeyFrames
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public PointAnimationUsingKeyFrames();

        public bool EnableDependentAnimation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty EnableDependentAnimationProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public PointKeyFrameCollection KeyFrames { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Xaml.Media.Animation.IPointAnimationUsingKeyFrames.EnableDependentAnimation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public PointKeyFrameCollection Windows.UI.Xaml.Media.Animation.IPointAnimationUsingKeyFrames.KeyFrames { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

