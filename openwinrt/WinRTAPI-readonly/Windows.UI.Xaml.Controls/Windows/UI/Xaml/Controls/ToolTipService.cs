namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls.Primitives;

    [Version(0x6020000), Threading(ThreadingModel.Both), MarshalingBehavior(MarshalingType.FreeThreaded), Static(typeof(IToolTipServiceStatics), 0x6020000), WebHostHidden]
    public sealed class ToolTipService : IToolTipService
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static PlacementMode GetPlacement([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static UIElement GetPlacementTarget([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static object GetToolTip([In] DependencyObject element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetPlacement([In] DependencyObject element, [In] PlacementMode value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetPlacementTarget([In] DependencyObject element, [In] UIElement value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetToolTip([In] DependencyObject element, [In] object value);

        public static DependencyProperty PlacementProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty PlacementTargetProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty ToolTipProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

