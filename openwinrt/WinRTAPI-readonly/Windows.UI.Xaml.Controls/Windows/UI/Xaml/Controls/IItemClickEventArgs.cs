namespace Windows.UI.Xaml.Controls
{
    using System;
    using Windows.Foundation.Metadata;

    [Guid(0x9c314242, 0xf29a, 0x494d, 0xa3, 0xa5, 0xd4, 0xc7, 0xb2, 0xa4, 0x68, 0x52), Version(0x6020000), ExclusiveTo(typeof(ItemClickEventArgs)), WebHostHidden]
    internal interface IItemClickEventArgs
    {
        object ClickedItem { get; }
    }
}

