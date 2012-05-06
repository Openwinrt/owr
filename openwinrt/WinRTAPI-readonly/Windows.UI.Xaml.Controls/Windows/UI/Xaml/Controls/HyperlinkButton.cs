namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls.Primitives;

    [Threading(ThreadingModel.Both), Composable(typeof(IHyperlinkButtonFactory), CompositionType.Public, 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), WebHostHidden, Version(0x6020000)]
    public class HyperlinkButton : ButtonBase, IHyperlinkButton
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public HyperlinkButton();
    }
}

