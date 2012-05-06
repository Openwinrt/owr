namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls.Primitives;

    [ExclusiveTo(typeof(VirtualizingPanel)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0x5ef6bd7d, 0x677f, 0x408d, 0xa9, 0x6c, 0xb1, 0x95, 7, 0x75, 4, 0x66), WebHostHidden]
    internal interface IVirtualizingPanelOverrides
    {
        void BringIndexIntoView([In] int index);
        void OnClearChildren();
        void OnItemsChanged([In] object sender, [In] ItemsChangedEventArgs args);
    }
}

