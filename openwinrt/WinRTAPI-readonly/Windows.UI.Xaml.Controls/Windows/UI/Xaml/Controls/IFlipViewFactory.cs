namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(FlipView)), WebHostHidden, Windows.Foundation.Metadata.Guid(0xf1dea9be, 0x9ae8, 0x4d4b, 0xab, 0x43, 0x16, 0xd3, 30, 5, 0xf4, 0xf3), Version(0x6020000)]
    internal interface IFlipViewFactory
    {
        FlipView CreateInstance([In] object outer, out object inner);
    }
}

