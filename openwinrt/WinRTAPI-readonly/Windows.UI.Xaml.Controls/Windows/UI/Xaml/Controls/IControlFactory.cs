namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(Control)), WebHostHidden, Windows.Foundation.Metadata.Guid(0xb12b1d5a, 0x6419, 0x4e16, 0xb2, 0x12, 0xa4, 0x53, 0x36, 0xb7, 0x57, 120), Version(0x6020000)]
    internal interface IControlFactory
    {
        Control CreateInstance([In] object outer, out object inner);
    }
}

