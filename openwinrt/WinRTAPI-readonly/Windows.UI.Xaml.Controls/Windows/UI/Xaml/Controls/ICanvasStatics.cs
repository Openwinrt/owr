namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [ExclusiveTo(typeof(Canvas)), Windows.Foundation.Metadata.Guid(0x40ce5c46, 0x2962, 0x446f, 170, 0xfb, 0x4c, 220, 0x48, 0x69, 0x39, 0xc9), WebHostHidden, Version(0x6020000)]
    internal interface ICanvasStatics
    {
        double GetLeft([In] UIElement element);
        double GetTop([In] UIElement element);
        int GetZIndex([In] UIElement element);
        void SetLeft([In] UIElement element, [In] double length);
        void SetTop([In] UIElement element, [In] double length);
        void SetZIndex([In] UIElement element, [In] int value);

        DependencyProperty LeftProperty { get; }

        DependencyProperty TopProperty { get; }

        DependencyProperty ZIndexProperty { get; }
    }
}

