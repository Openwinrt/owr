namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Markup;

    [Threading(ThreadingModel.Both), Activatable(0x6020000), WebHostHidden, Static(typeof(IObjectAnimationUsingKeyFramesStatics), 0x6020000), Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), ContentProperty(Name="KeyFrames")]
    public sealed class ObjectAnimationUsingKeyFrames : Timeline, IObjectAnimationUsingKeyFrames
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ObjectAnimationUsingKeyFrames();

        public bool EnableDependentAnimation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty EnableDependentAnimationProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ObjectKeyFrameCollection KeyFrames { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Xaml.Media.Animation.IObjectAnimationUsingKeyFrames.EnableDependentAnimation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public ObjectKeyFrameCollection Windows.UI.Xaml.Media.Animation.IObjectAnimationUsingKeyFrames.KeyFrames { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

