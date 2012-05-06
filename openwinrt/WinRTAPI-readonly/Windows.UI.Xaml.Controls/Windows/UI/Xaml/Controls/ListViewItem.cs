namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls.Primitives;

    [WebHostHidden, Composable(typeof(IListViewItemFactory), CompositionType.Public, 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000), Threading(ThreadingModel.Both)]
    public class ListViewItem : SelectorItem, IListViewItem
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ListViewItem();

        public ListViewItemTemplateSettings TemplateSettings { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ListViewItemTemplateSettings Windows.UI.Xaml.Controls.IListViewItem.TemplateSettings { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

