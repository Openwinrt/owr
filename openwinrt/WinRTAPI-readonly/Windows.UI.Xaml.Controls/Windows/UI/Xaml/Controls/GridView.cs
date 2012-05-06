namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Composable(typeof(IGridViewFactory), CompositionType.Public, 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both), WebHostHidden, Version(0x6020000)]
    public class GridView : ListViewBase, IGridView
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public GridView();
    }
}

