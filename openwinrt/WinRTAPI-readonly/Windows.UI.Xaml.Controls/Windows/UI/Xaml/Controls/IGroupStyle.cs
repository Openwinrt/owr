namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [WebHostHidden, Version(0x6020000), Windows.Foundation.Metadata.Guid(0x71ca300b, 0xb89e, 0x4184, 0xb0, 0xdf, 0xa9, 0xe9, 0x54, 0x47, 0xde, 0x8d), ExclusiveTo(typeof(GroupStyle))]
    internal interface IGroupStyle
    {
        Style ContainerStyle { get; [param: In] set; }

        StyleSelector ContainerStyleSelector { get; [param: In] set; }

        DataTemplate HeaderTemplate { get; [param: In] set; }

        DataTemplateSelector HeaderTemplateSelector { get; [param: In] set; }

        bool HidesIfEmpty { get; [param: In] set; }

        ItemsPanelTemplate Panel { get; [param: In] set; }
    }
}

