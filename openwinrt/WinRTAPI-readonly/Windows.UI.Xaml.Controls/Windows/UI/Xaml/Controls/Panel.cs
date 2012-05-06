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

    [Composable(typeof(IPanelFactory), CompositionType.Protected, 0x6020000), Version(0x6020000), Static(typeof(IPanelStatics), 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), WebHostHidden, ContentProperty(Name="Children"), Threading(ThreadingModel.Both)]
    public class Panel : FrameworkElement, IPanel
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected Panel();

        public Brush Background { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty BackgroundProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public UIElementCollection Children { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public TransitionCollection ChildrenTransitions { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty ChildrenTransitionsProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool IsItemsHost { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty IsItemsHostProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Brush Windows.UI.Xaml.Controls.IPanel.Background { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public UIElementCollection Windows.UI.Xaml.Controls.IPanel.Children { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public TransitionCollection Windows.UI.Xaml.Controls.IPanel.ChildrenTransitions { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.UI.Xaml.Controls.IPanel.IsItemsHost { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

