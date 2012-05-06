namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [WebHostHidden, MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000), Threading(ThreadingModel.Both), Static(typeof(IFadeOutThemeAnimationStatics), 0x6020000), Activatable(0x6020000)]
    public sealed class FadeOutThemeAnimation : Timeline, IFadeOutThemeAnimation
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public FadeOutThemeAnimation();

        public string TargetName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty TargetNameProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.UI.Xaml.Media.Animation.IFadeOutThemeAnimation.TargetName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

