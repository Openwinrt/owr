namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [WebHostHidden, Static(typeof(IDragItemThemeAnimationStatics), 0x6020000), Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both), Activatable(0x6020000)]
    public sealed class DragItemThemeAnimation : Timeline, IDragItemThemeAnimation
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public DragItemThemeAnimation();

        public string TargetName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty TargetNameProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.UI.Xaml.Media.Animation.IDragItemThemeAnimation.TargetName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

