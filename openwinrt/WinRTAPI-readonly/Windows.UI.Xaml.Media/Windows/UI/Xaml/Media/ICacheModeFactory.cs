namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Version(0x6020000), ExclusiveTo(typeof(CacheMode)), Windows.Foundation.Metadata.Guid(0xeb1f8c5b, 0xabb, 0x4e70, 0xb8, 0xa8, 0x62, 13, 13, 0x95, 0x3a, 0xb2)]
    internal interface ICacheModeFactory
    {
        CacheMode CreateInstance([In] object outer, out object inner);
    }
}

