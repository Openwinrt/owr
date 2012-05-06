namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Windows.Foundation.Metadata.Guid(0xf431073d, 0x9cac, 0x42a2, 130, 0xdf, 15, 0x44, 0x90, 0xbc, 0x4e, 0x2e), Version(0x6020000), ExclusiveTo(typeof(ListViewItem))]
    internal interface IListViewItemFactory
    {
        ListViewItem CreateInstance([In] object outer, out object inner);
    }
}

