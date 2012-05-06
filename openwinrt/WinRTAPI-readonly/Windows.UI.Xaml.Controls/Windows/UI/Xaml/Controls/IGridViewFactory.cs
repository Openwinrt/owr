namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(GridView)), Version(0x6020000), WebHostHidden, Windows.Foundation.Metadata.Guid(0xd9bcca89, 0x9f9, 0x4c6e, 0xa8, 0x3e, 0xf1, 0x99, 20, 0x6f, 14, 0x7d)]
    internal interface IGridViewFactory
    {
        GridView CreateInstance([In] object outer, out object inner);
    }
}

