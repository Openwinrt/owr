namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls.Primitives;

    [Composable(typeof(IFlipViewFactory), CompositionType.Public, 0x6020000), Threading(ThreadingModel.Both), Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), WebHostHidden]
    public class FlipView : Selector, IFlipView
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public FlipView();
    }
}

