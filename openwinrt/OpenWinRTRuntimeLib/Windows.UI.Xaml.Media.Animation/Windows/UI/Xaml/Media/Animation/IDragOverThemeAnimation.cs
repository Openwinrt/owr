namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls.Primitives;

    [ExclusiveTo(typeof(DragOverThemeAnimation)), WebHostHidden, Windows.Foundation.Metadata.Guid(0x72f762f7, 0x7e51, 0x4a6b, 0xb9, 0x37, 220, 0x4b, 0x4c, 0x1c, 0x54, 0x58), Version(0x6020000)]
    internal interface IDragOverThemeAnimation
    {
        AnimationDirection Direction { get; [param: In] set; }

        string TargetName { get; [param: In] set; }

        double ToOffset { get; [param: In] set; }
    }
}

