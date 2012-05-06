namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0xe67e6c7f, 0x150f, 0x46d0, 0xa6, 0xac, 0xc5, 0, 0x2b, 0xd9, 0xca, 0x53), ExclusiveTo(typeof(ListViewBase)), WebHostHidden]
    internal interface IListViewBaseFactory
    {
        ListViewBase CreateInstance([In] object outer, out object inner);
    }
}

