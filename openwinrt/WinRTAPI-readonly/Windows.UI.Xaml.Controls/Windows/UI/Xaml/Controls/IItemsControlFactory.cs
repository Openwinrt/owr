namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Version(0x6020000), Windows.Foundation.Metadata.Guid(0xf7bbc359, 0xf8fd, 0x471c, 0xbc, 0xb2, 0x2c, 0x74, 190, 0x8e, 0xbf, 140), ExclusiveTo(typeof(ItemsControl))]
    internal interface IItemsControlFactory
    {
        ItemsControl CreateInstance([In] object outer, out object inner);
    }
}

