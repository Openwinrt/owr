namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls.Primitives;

    [Threading(ThreadingModel.Both), WebHostHidden, Version(0x6020000), Composable(typeof(IGridViewItemFactory), CompositionType.Public, 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public class GridViewItem : SelectorItem, IGridViewItem
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public GridViewItem();

        public GridViewItemTemplateSettings TemplateSettings { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public GridViewItemTemplateSettings Windows.UI.Xaml.Controls.IGridViewItem.TemplateSettings { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

