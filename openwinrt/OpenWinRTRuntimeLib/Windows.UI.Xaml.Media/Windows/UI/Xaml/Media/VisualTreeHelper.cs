namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Static(typeof(IVisualTreeHelperStatics), 0x6020000), Threading(ThreadingModel.Both), WebHostHidden, MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000)]
    public sealed class VisualTreeHelper : IVisualTreeHelper
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void DisconnectChildrenRecursive([In] UIElement element);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("FindElementsInHostCoordinatesPoint"), DefaultOverload]
        public static IIterable<UIElement> FindElementsInHostCoordinates([In] Point intersectingPoint, [In] UIElement subtree);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("FindElementsInHostCoordinatesRect")]
        public static IIterable<UIElement> FindElementsInHostCoordinates([In] Rect intersectingRect, [In] UIElement subtree);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), DefaultOverload, Overload("FindAllElementsInHostCoordinatesPoint")]
        public static IIterable<UIElement> FindElementsInHostCoordinates([In] Point intersectingPoint, [In] UIElement subtree, [In] bool includeAllElements);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("FindAllElementsInHostCoordinatesRect")]
        public static IIterable<UIElement> FindElementsInHostCoordinates([In] Rect intersectingRect, [In] UIElement subtree, [In] bool includeAllElements);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static DependencyObject GetChild([In] DependencyObject reference, [In] int childIndex);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static int GetChildrenCount([In] DependencyObject reference);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static DependencyObject GetParent([In] DependencyObject reference);
    }
}

