namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), WebHostHidden, Windows.Foundation.Metadata.Guid(0x4398b8d4, 0xa3de, 0x402c, 0xb2, 0x3d, 0x19, 3, 0x84, 0xb2, 0x7c, 0xa8), ExclusiveTo(typeof(ListBoxItem))]
    internal interface IListBoxItemFactory
    {
        ListBoxItem CreateInstance([In] object outer, out object inner);
    }
}

