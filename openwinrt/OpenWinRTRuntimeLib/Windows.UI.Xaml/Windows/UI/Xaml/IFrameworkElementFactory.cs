namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), WebHostHidden, Windows.Foundation.Metadata.Guid(0xdeaee126, 970, 0x4966, 0xb5, 0x76, 0x60, 0x4c, 0xce, 0x93, 0xb5, 0xe8), ExclusiveTo(typeof(FrameworkElement))]
    internal interface IFrameworkElementFactory
    {
        FrameworkElement CreateInstance([In] object outer, out object inner);
    }
}

