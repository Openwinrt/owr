namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x6dda119e, 0x9a74, 0x478f, 0xa3, 0x39, 0x5b, 0xb5, 0x2d, 230, 0xc5, 30), ExclusiveTo(typeof(GroupStyleSelector)), WebHostHidden, Version(0x6020000)]
    internal interface IGroupStyleSelector
    {
        GroupStyle SelectGroupStyle([In] object group, [In] uint level);
    }
}

