namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x198289d4, 0xc89b, 0x49b2, 0x89, 0x6c, 0x59, 0x17, 0xbf, 0x8a, 220, 0xae), ExclusiveTo(typeof(SwapChainBackgroundPanel)), WebHostHidden, Version(0x6020000)]
    internal interface ISwapChainBackgroundPanelFactory
    {
        SwapChainBackgroundPanel CreateInstance([In] object outer, out object inner);
    }
}

