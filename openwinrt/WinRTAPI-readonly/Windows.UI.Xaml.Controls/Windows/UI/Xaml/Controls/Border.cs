namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Markup;
    using Windows.UI.Xaml.Media;
    using Windows.UI.Xaml.Media.Animation;

    [Static(typeof(IBorderStatics), 0x6020000), WebHostHidden, Threading(ThreadingModel.Both), Activatable(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000), ContentProperty(Name="Child")]
    public sealed class Border : FrameworkElement, IBorder
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Border();

        public Brush Background { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty BackgroundProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Brush BorderBrush { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty BorderBrushProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Thickness BorderThickness { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty BorderThicknessProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public UIElement Child { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public TransitionCollection ChildTransitions { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty ChildTransitionsProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.CornerRadius CornerRadius { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty CornerRadiusProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Thickness Padding { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty PaddingProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Brush Windows.UI.Xaml.Controls.IBorder.Background { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Brush Windows.UI.Xaml.Controls.IBorder.BorderBrush { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Thickness Windows.UI.Xaml.Controls.IBorder.BorderThickness { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public UIElement Windows.UI.Xaml.Controls.IBorder.Child { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public TransitionCollection Windows.UI.Xaml.Controls.IBorder.ChildTransitions { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.UI.Xaml.CornerRadius Windows.UI.Xaml.Controls.IBorder.CornerRadius { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Thickness Windows.UI.Xaml.Controls.IBorder.Padding { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

