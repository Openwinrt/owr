namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Version(0x6020000), ExclusiveTo(typeof(FlipViewItem)), Windows.Foundation.Metadata.Guid(0xf21d91fe, 0x22a0, 0x4412, 0xa8, 0x53, 0x9d, 0x6a, 110, 0x8f, 0x2a, 0xaf)]
    internal interface IFlipViewItemFactory
    {
        FlipViewItem CreateInstance([In] object outer, out object inner);
    }
}

