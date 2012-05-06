namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls.Primitives;

    [Composable(typeof(IListBoxItemFactory), CompositionType.Public, 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), WebHostHidden, Version(0x6020000), Threading(ThreadingModel.Both)]
    public class ListBoxItem : SelectorItem, IListBoxItem
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ListBoxItem();
    }
}

