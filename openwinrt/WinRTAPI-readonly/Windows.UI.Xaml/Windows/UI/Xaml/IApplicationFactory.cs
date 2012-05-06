namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x93bbe361, 0xbe5a, 0x4ee3, 180, 0xa3, 0x95, 0x11, 0x8d, 0xc9, 0x7a, 0x89), WebHostHidden, Version(0x6020000), ExclusiveTo(typeof(Application))]
    internal interface IApplicationFactory
    {
        Application CreateInstance([In] object outer, out object inner);
    }
}

