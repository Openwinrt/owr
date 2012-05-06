namespace Windows.UI.Xaml.Controls
{
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [WebHostHidden, ExclusiveTo(typeof(ItemsControl)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0x37dabd89, 0xdcfb, 0x45b8, 0x9a, 0xfe, 0x87, 0x4d, 240, 0x97, 0x90, 0x5e)]
    internal interface IItemsControlStatics
    {
        ItemsControl GetItemsOwner([In] DependencyObject element);
        ItemsControl ItemsControlFromItemContainer([In] DependencyObject container);

        DependencyProperty DisplayMemberPathProperty { get; }

        DependencyProperty GroupStyleSelectorProperty { get; }

        DependencyProperty IsGroupingProperty { get; }

        DependencyProperty ItemContainerStyleProperty { get; }

        DependencyProperty ItemContainerStyleSelectorProperty { get; }

        DependencyProperty ItemContainerTransitionsProperty { get; }

        DependencyProperty ItemsPanelProperty { get; }

        DependencyProperty ItemsSourceProperty { get; }

        DependencyProperty ItemTemplateProperty { get; }

        DependencyProperty ItemTemplateSelectorProperty { get; }
    }
}

