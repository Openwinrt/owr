namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(ListView)), WebHostHidden, Windows.Foundation.Metadata.Guid(0xbdff696d, 0x3f22, 0x41f9, 0x97, 0xa6, 0x88, 0x31, 0x34, 0xa7, 0x61, 0x13), Version(0x6020000)]
    internal interface IListViewFactory
    {
        ListView CreateInstance([In] object outer, out object inner);
    }
}

