namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Media;
    using Windows.UI.Xaml.Media.Animation;

    [Windows.Foundation.Metadata.Guid(0x797c4539, 0x45bd, 0x4633, 160, 0x44, 0xbf, 0xb0, 0x2e, 0xf5, 0x17, 15), ExclusiveTo(typeof(Border)), Version(0x6020000), WebHostHidden]
    internal interface IBorder
    {
        Brush Background { get; [param: In] set; }

        Brush BorderBrush { get; [param: In] set; }

        Thickness BorderThickness { get; [param: In] set; }

        UIElement Child { get; [param: In] set; }

        TransitionCollection ChildTransitions { get; [param: In] set; }

        Windows.UI.Xaml.CornerRadius CornerRadius { get; [param: In] set; }

        Thickness Padding { get; [param: In] set; }
    }
}

