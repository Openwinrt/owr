namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both), WebHostHidden, Composable(typeof(IListViewFactory), CompositionType.Public, 0x6020000), Version(0x6020000)]
    public class ListView : ListViewBase, IListView
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ListView();
    }
}

