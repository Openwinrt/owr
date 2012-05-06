namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xf691cab2, 0x77ad, 0x4d3d, 0xa5, 0x1c, 0x8e, 0xf9, 0xc3, 0x83, 100, 0x56), WebHostHidden, Version(0x6020000), ExclusiveTo(typeof(GroupStyleSelector))]
    internal interface IGroupStyleSelectorOverrides
    {
        GroupStyle SelectGroupStyleCore([In] object group, [In] uint level);
    }
}

