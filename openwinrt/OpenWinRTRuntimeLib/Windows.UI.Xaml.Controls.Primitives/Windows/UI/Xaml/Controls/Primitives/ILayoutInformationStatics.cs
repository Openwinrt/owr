namespace Windows.UI.Xaml.Controls.Primitives
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0xcf06cf99, 0x58e9, 0x4682, 0x83, 0x26, 80, 0xca, 0xab, 0x65, 0xed, 0x7c), ExclusiveTo(typeof(LayoutInformation)), WebHostHidden]
    internal interface ILayoutInformationStatics
    {
        UIElement GetLayoutExceptionElement([In] object dispatcher);
        Rect GetLayoutSlot([In] FrameworkElement element);
    }
}

