namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls.Primitives;

    [Composable(typeof(IButtonFactory), CompositionType.Public, 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both), Version(0x6020000), WebHostHidden]
    public class Button : ButtonBase, IButton
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Button();
    }
}

