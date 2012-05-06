namespace Windows.UI.Xaml.Controls.Primitives
{
    using System;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Version(0x6020000), ExclusiveTo(typeof(GridViewItemTemplateSettings)), Guid(0x9e30baaf, 0x165d, 0x4267, 0xa4, 0x5e, 0x1a, 0x43, 0xa7, 0x57, 6, 0xac)]
    internal interface IGridViewItemTemplateSettings
    {
        int DragItemsCount { get; }
    }
}

