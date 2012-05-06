namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(Frame)), Windows.Foundation.Metadata.Guid(0x2ee93d4, 0x448e, 0x469e, 0x97, 0x99, 10, 0x8a, 0x1f, 0x70, 0xf1, 0x71), Version(0x6020000), WebHostHidden]
    internal interface IFrameFactory
    {
        Frame CreateInstance([In] object outer, out object inner);
    }
}

