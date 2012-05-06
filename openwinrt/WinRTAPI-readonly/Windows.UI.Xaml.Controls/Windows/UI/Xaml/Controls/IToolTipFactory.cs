namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Version(0x6020000), Windows.Foundation.Metadata.Guid(0x89839403, 0xb538, 0x49e3, 0xa4, 0x30, 0x3a, 0xc0, 0x37, 220, 0x6f, 0xe0), ExclusiveTo(typeof(ToolTip))]
    internal interface IToolTipFactory
    {
        ToolTip CreateInstance([In] object outer, out object inner);
    }
}

