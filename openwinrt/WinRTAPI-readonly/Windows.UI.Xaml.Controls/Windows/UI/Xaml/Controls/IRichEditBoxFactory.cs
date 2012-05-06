namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x61a1df62, 0x2806, 0x41ed, 0x88, 0xed, 0xae, 0x21, 0xf4, 0x7a, 180, 0x22), Version(0x6020000), ExclusiveTo(typeof(RichEditBox)), WebHostHidden]
    internal interface IRichEditBoxFactory
    {
        RichEditBox CreateInstance([In] object outer, out object inner);
    }
}

