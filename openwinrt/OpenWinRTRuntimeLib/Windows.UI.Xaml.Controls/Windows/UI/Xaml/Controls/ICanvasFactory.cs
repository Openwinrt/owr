namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x1b328bd1, 0xb400, 0x4a8e, 0x94, 0x3b, 90, 210, 0xc4, 0x5b, 0xe0, 0xdf), WebHostHidden, Version(0x6020000), ExclusiveTo(typeof(Canvas))]
    internal interface ICanvasFactory
    {
        Canvas CreateInstance([In] object outer, out object inner);
    }
}

