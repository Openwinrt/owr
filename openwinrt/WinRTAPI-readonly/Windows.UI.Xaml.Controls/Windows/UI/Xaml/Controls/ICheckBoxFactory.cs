namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x4fa6aabb, 0x3f4b, 0x4301, 190, 7, 0x11, 0x72, 0xea, 0x61, 0xee, 0xfb), ExclusiveTo(typeof(CheckBox)), Version(0x6020000), WebHostHidden]
    internal interface ICheckBoxFactory
    {
        CheckBox CreateInstance([In] object outer, out object inner);
    }
}

