namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Windows.Foundation.Metadata.Guid(0xda007e54, 0xb3c2, 0x4b9a, 170, 0x8e, 0xd3, 240, 0x71, 0x26, 0x2b, 0x97), Version(0x6020000), ExclusiveTo(typeof(FrameworkElement))]
    internal interface IFrameworkElementOverrides
    {
        Size ArrangeOverride([In] Size finalSize);
        Size MeasureOverride([In] Size availableSize);
        void OnApplyTemplate();
    }
}

