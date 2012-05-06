namespace Windows.UI.Xaml.Controls.Primitives
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xd56aa2fc, 0xfc7f, 0x449c, 0x98, 0x55, 0x7a, 0x10, 0x55, 0xd6, 0x68, 0xa8), ExclusiveTo(typeof(ToggleButton)), WebHostHidden, Version(0x6020000)]
    internal interface IToggleButtonFactory
    {
        ToggleButton CreateInstance([In] object outer, out object inner);
    }
}

