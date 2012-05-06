namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls.Primitives;

    [Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both), WebHostHidden, Composable(typeof(IComboBoxItemFactory), CompositionType.Public, 0x6020000)]
    public class ComboBoxItem : SelectorItem, IComboBoxItem
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ComboBoxItem();
    }
}

