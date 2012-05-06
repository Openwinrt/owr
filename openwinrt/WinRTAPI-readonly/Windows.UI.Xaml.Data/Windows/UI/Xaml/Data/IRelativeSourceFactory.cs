namespace Windows.UI.Xaml.Data
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), WebHostHidden, Windows.Foundation.Metadata.Guid(0xef8392cd, 0x446e, 0x4f93, 170, 0xcb, 0x9b, 0x12, 0x55, 0x57, 0x74, 0x60), ExclusiveTo(typeof(RelativeSource))]
    internal interface IRelativeSourceFactory
    {
        RelativeSource CreateInstance([In] object outer, out object inner);
    }
}

