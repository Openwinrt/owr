namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(TileBrush)), Windows.Foundation.Metadata.Guid(0xaa159f7c, 0xed6a, 0x4fb3, 0xb0, 20, 0xb5, 0xc7, 0xe3, 0x79, 0xa4, 0xde), WebHostHidden, Version(0x6020000)]
    internal interface ITileBrushFactory
    {
        TileBrush CreateInstance([In] object outer, out object inner);
    }
}

