namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(DropTargetItemThemeAnimation)), Windows.Foundation.Metadata.Guid(0x1881c968, 0x1824, 0x462b, 0x87, 0xe8, 0xc3, 0x57, 0x21, 0x2b, 0x97, 0x7b), WebHostHidden, Version(0x6020000)]
    internal interface IDropTargetItemThemeAnimation
    {
        string TargetName { get; [param: In] set; }
    }
}

