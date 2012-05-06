namespace Windows.UI.Xaml.Controls.Primitives
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both), Version(0x6020000), WebHostHidden]
    public sealed class GridViewItemTemplateSettings : DependencyObject, IGridViewItemTemplateSettings
    {
        public int DragItemsCount { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int Windows.UI.Xaml.Controls.Primitives.IGridViewItemTemplateSettings.DragItemsCount { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

