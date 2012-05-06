namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls.Primitives;

    [Version(0x6020000), ExclusiveTo(typeof(ItemContainerGenerator)), WebHostHidden, Windows.Foundation.Metadata.Guid(0x40765f00, 0x83f0, 0x4d7f, 0xb1, 0xb8, 0xf1, 0x9d, 0xe4, 0xf1, 0xd5, 0xda)]
    internal interface IItemContainerGenerator
    {
        event ItemsChangedEventHandler ItemsChanged;

        DependencyObject ContainerFromIndex([In] int index);
        DependencyObject ContainerFromItem([In] object item);
        int IndexFromContainer([In] DependencyObject container);
        object ItemFromContainer([In] DependencyObject container);
    }
}

