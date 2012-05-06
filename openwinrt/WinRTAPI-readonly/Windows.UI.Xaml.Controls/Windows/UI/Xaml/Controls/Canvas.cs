namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [WebHostHidden, MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000), Static(typeof(ICanvasStatics), 0x6020000), Threading(ThreadingModel.Both), Composable(typeof(ICanvasFactory), CompositionType.Public, 0x6020000)]
    public class Canvas : Panel, ICanvas
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Canvas();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static double GetLeft([In] UIElement element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static double GetTop([In] UIElement element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static int GetZIndex([In] UIElement element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetLeft([In] UIElement element, [In] double length);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetTop([In] UIElement element, [In] double length);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetZIndex([In] UIElement element, [In] int value);

        public static DependencyProperty LeftProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty TopProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty ZIndexProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

