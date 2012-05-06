namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Windows.Foundation.Metadata.Guid(0xe75758c4, 0xd25d, 0x4b1d, 0x97, 0x1f, 0x59, 0x6f, 0x17, 0xf1, 0x2b, 170), ExclusiveTo(typeof(VisualTreeHelper)), Version(0x6020000), WebHostHidden]
    internal interface IVisualTreeHelperStatics
    {
        void DisconnectChildrenRecursive([In] UIElement element);
        [Overload("FindElementsInHostCoordinatesPoint"), DefaultOverload]
        IIterable<UIElement> FindElementsInHostCoordinates([In] Point intersectingPoint, [In] UIElement subtree);
        [Overload("FindElementsInHostCoordinatesRect")]
        IIterable<UIElement> FindElementsInHostCoordinates([In] Rect intersectingRect, [In] UIElement subtree);
        [DefaultOverload, Overload("FindAllElementsInHostCoordinatesPoint")]
        IIterable<UIElement> FindElementsInHostCoordinates([In] Point intersectingPoint, [In] UIElement subtree, [In] bool includeAllElements);
        [Overload("FindAllElementsInHostCoordinatesRect")]
        IIterable<UIElement> FindElementsInHostCoordinates([In] Rect intersectingRect, [In] UIElement subtree, [In] bool includeAllElements);
        DependencyObject GetChild([In] DependencyObject reference, [In] int childIndex);
        int GetChildrenCount([In] DependencyObject reference);
        DependencyObject GetParent([In] DependencyObject reference);
    }
}

