namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Markup;

    [MarshalingBehavior(MarshalingType.FreeThreaded), WebHostHidden, Activatable(0x6020000), Threading(ThreadingModel.Both), ContentProperty(Name="KeyFrames"), Version(0x6020000), Static(typeof(IColorAnimationUsingKeyFramesStatics), 0x6020000)]
    public sealed class ColorAnimationUsingKeyFrames : Timeline, IColorAnimationUsingKeyFrames
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ColorAnimationUsingKeyFrames();

        public bool EnableDependentAnimation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty EnableDependentAnimationProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ColorKeyFrameCollection KeyFrames { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Xaml.Media.Animation.IColorAnimationUsingKeyFrames.EnableDependentAnimation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public ColorKeyFrameCollection Windows.UI.Xaml.Media.Animation.IColorAnimationUsingKeyFrames.KeyFrames { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

