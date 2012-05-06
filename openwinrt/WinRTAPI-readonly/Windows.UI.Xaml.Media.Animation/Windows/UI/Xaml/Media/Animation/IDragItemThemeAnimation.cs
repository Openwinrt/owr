namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(DragItemThemeAnimation)), Version(0x6020000), WebHostHidden, Windows.Foundation.Metadata.Guid(0xc7d5db5, 0x7ed6, 0x4949, 180, 230, 0xa7, 140, 0x9f, 0x4f, 0x97, 0x8d)]
    internal interface IDragItemThemeAnimation
    {
        string TargetName { get; [param: In] set; }
    }
}

