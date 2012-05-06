namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(ListBox)), WebHostHidden, Windows.Foundation.Metadata.Guid(0x60cdfda2, 0x2f44, 0x444b, 0x9c, 0x94, 0xb8, 0xc9, 0xfd, 0xa4, 0x6f, 0x59)]
    internal interface IListBoxFactory
    {
        ListBox CreateInstance([In] object outer, out object inner);
    }
}

