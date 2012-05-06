namespace Windows.UI.Xaml.Controls.Primitives
{
    using System;
    using Windows.Foundation.Metadata;

    [Guid(0x67af84bf, 0x8279, 0x4686, 0x93, 0x26, 0xcd, 0x18, 0x9f, 0x27, 0x57, 0x5d), WebHostHidden, ExclusiveTo(typeof(ListViewItemTemplateSettings)), Version(0x6020000)]
    internal interface IListViewItemTemplateSettings
    {
        int DragItemsCount { get; }
    }
}

