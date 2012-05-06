namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(CornerRadiusHelper)), WebHostHidden, Windows.Foundation.Metadata.Guid(0xf4a1f659, 0xd4d4, 0x451f, 0xa3, 0x87, 0xd6, 0xbf, 0x4b, 0x24, 0x51, 0xd4)]
    internal interface ICornerRadiusHelperStatics
    {
        CornerRadius FromRadii([In] double topLeft, [In] double topRight, [In] double bottomRight, [In] double bottomLeft);
        CornerRadius FromUniformRadius([In] double uniformRadius);
    }
}

