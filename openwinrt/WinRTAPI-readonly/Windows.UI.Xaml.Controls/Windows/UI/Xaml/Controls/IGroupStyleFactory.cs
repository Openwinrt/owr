namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x56ff664f, 0xe2d7, 0x4f49, 0x80, 0x3d, 0xc7, 0x27, 0xcd, 0xf9, 0x37, 0x2d), Version(0x6020000), WebHostHidden, ExclusiveTo(typeof(GroupStyle))]
    internal interface IGroupStyleFactory
    {
        GroupStyle CreateInstance([In] object outer, out object inner);
    }
}

