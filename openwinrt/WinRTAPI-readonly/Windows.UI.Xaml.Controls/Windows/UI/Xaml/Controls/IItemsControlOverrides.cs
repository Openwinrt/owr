namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [WebHostHidden, Windows.Foundation.Metadata.Guid(0xc79bb41b, 0xa084, 0x4301, 0xa4, 150, 0x72, 0x97, 0x1f, 0x36, 0x4e, 0xd1), Version(0x6020000), ExclusiveTo(typeof(ItemsControl))]
    internal interface IItemsControlOverrides
    {
        void ClearContainerForItemOverride([In] DependencyObject element, [In] object item);
        DependencyObject GetContainerForItemOverride();
        bool IsItemItsOwnContainerOverride([In] object item);
        void OnGroupStyleSelectorChanged([In] GroupStyleSelector oldGroupStyleSelector, [In] GroupStyleSelector newGroupStyleSelector);
        void OnItemContainerStyleChanged([In] Style oldItemContainerStyle, [In] Style newItemContainerStyle);
        void OnItemContainerStyleSelectorChanged([In] StyleSelector oldItemContainerStyleSelector, [In] StyleSelector newItemContainerStyleSelector);
        void OnItemsChanged([In] object e);
        void OnItemTemplateChanged([In] DataTemplate oldItemTemplate, [In] DataTemplate newItemTemplate);
        void OnItemTemplateSelectorChanged([In] DataTemplateSelector oldItemTemplateSelector, [In] DataTemplateSelector newItemTemplateSelector);
        void PrepareContainerForItemOverride([In] DependencyObject element, [In] object item);
    }
}

