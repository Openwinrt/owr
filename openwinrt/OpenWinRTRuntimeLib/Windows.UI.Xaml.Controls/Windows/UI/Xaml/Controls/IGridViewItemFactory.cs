namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Windows.Foundation.Metadata.Guid(0x229b00af, 0x3fa6, 0x43e9, 0x97, 0x9d, 7, 0xea, 13, 0x62, 0x80, 220), ExclusiveTo(typeof(GridViewItem)), Version(0x6020000)]
    internal interface IGridViewItemFactory
    {
        GridViewItem CreateInstance([In] object outer, out object inner);
    }
}

