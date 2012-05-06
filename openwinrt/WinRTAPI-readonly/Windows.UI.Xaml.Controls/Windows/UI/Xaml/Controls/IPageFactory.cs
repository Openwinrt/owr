namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0xdfa149ac, 0x1849, 0x445e, 0x93, 0x7c, 0x40, 0xa9, 0x59, 12, 0xc0, 0x76), ExclusiveTo(typeof(Page)), WebHostHidden]
    internal interface IPageFactory
    {
        Page CreateInstance([In] object outer, out object inner);
    }
}

