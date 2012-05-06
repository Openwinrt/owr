namespace Windows.UI.Xaml.Data
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0xa031e6dd, 0xbbb6, 0x4b6a, 0x9c, 0x76, 0x13, 0xf3, 0xea, 0xff, 140, 0x29), WebHostHidden]
    public interface ISupportPlaceholder
    {
        bool IsPlaceholder([In] object item);
    }
}

