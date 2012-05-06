namespace Windows.UI.Xaml.Controls.Primitives
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [MarshalingBehavior(MarshalingType.FreeThreaded), WebHostHidden, Version(0x6020000), Threading(ThreadingModel.Both)]
    public sealed class ListViewItemTemplateSettings : DependencyObject, IListViewItemTemplateSettings
    {
        public int DragItemsCount { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int Windows.UI.Xaml.Controls.Primitives.IListViewItemTemplateSettings.DragItemsCount { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

