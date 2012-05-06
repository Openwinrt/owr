namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls.Primitives;

    [Threading(ThreadingModel.Both), WebHostHidden, Composable(typeof(IFlipViewItemFactory), CompositionType.Public, 0x6020000), Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public class FlipViewItem : SelectorItem, IFlipViewItem
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public FlipViewItem();
    }
}

