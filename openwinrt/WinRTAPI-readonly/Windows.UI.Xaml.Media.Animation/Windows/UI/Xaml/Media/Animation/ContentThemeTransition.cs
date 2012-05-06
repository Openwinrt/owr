namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [WebHostHidden, Threading(ThreadingModel.Both), Static(typeof(IContentThemeTransitionStatics), 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000), Activatable(0x6020000)]
    public sealed class ContentThemeTransition : Transition, IContentThemeTransition
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ContentThemeTransition();

        public double HorizontalOffset { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty HorizontalOffsetProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double VerticalOffset { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty VerticalOffsetProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Media.Animation.IContentThemeTransition.HorizontalOffset { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public double Windows.UI.Xaml.Media.Animation.IContentThemeTransition.VerticalOffset { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

