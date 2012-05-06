namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls.Primitives;

    [Version(0x6020000), Threading(ThreadingModel.Both), Static(typeof(IEdgeUIThemeTransitionStatics), 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), WebHostHidden, Activatable(0x6020000)]
    public sealed class EdgeUIThemeTransition : Transition, IEdgeUIThemeTransition
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public EdgeUIThemeTransition();

        public EdgeTransitionLocation Edge { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty EdgeProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public EdgeTransitionLocation Windows.UI.Xaml.Media.Animation.IEdgeUIThemeTransition.Edge { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

