namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xbf570d33, 0xb2f6, 0x481f, 0xa4, 80, 200, 12, 0x29, 0x1f, 0xb2, 0x2d), Version(0x6020000), ExclusiveTo(typeof(GroupStyleSelector)), WebHostHidden]
    internal interface IGroupStyleSelectorFactory
    {
        GroupStyleSelector CreateInstance([In] object outer, out object inner);
    }
}

