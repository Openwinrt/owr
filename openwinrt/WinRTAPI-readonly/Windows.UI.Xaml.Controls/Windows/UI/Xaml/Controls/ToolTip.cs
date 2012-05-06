namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls.Primitives;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both), Version(0x6020000), WebHostHidden, Composable(typeof(IToolTipFactory), CompositionType.Public, 0x6020000), Static(typeof(IToolTipStatics), 0x6020000)]
    public class ToolTip : ContentControl, IToolTip
    {
        public event RoutedEventHandler Closed;

        public event RoutedEventHandler Opened;

        public event RoutedEventHandler Windows.UI.Xaml.Controls.IToolTip.Closed;

        public event RoutedEventHandler Windows.UI.Xaml.Controls.IToolTip.Opened;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ToolTip();

        public double HorizontalOffset { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty HorizontalOffsetProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool IsOpen { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty IsOpenProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public PlacementMode Placement { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty PlacementProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public UIElement PlacementTarget { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty PlacementTargetProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ToolTipTemplateSettings TemplateSettings { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double VerticalOffset { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty VerticalOffsetProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Controls.IToolTip.HorizontalOffset { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.UI.Xaml.Controls.IToolTip.IsOpen { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public PlacementMode Windows.UI.Xaml.Controls.IToolTip.Placement { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public UIElement Windows.UI.Xaml.Controls.IToolTip.PlacementTarget { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public ToolTipTemplateSettings Windows.UI.Xaml.Controls.IToolTip.TemplateSettings { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Controls.IToolTip.VerticalOffset { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

