namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [WebHostHidden, ExclusiveTo(typeof(VirtualizingPanel)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0xc9c9ab42, 0xc232, 0x479d, 0xa7, 0xc9, 0x5e, 0x76, 0x11, 0x19, 0x6a, 0x45)]
    internal interface IVirtualizingPanelProtected
    {
        void AddInternalChild([In] UIElement child);
        void InsertInternalChild([In] int index, [In] UIElement child);
        void RemoveInternalChildRange([In] int index, [In] int range);
    }
}

