namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), WebHostHidden, Threading(ThreadingModel.Both), Composable(typeof(ISwapChainBackgroundPanelFactory), CompositionType.Public, 0x6020000)]
    public class SwapChainBackgroundPanel : Grid, ISwapChainBackgroundPanel
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public SwapChainBackgroundPanel();
    }
}

