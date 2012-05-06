namespace Windows.UI.Xaml.Controls.Primitives
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [WebHostHidden, ExclusiveTo(typeof(RangeBase)), Windows.Foundation.Metadata.Guid(0x4291af39, 0x7f0b, 0x4bc2, 0x99, 0xc4, 6, 0xe7, 6, 0x26, 130, 0xd8), Version(0x6020000)]
    internal interface IRangeBaseOverrides
    {
        void OnMaximumChanged([In] double oldMaximum, [In] double newMaximum);
        void OnMinimumChanged([In] double oldMinimum, [In] double newMinimum);
        void OnValueChanged([In] double oldValue, [In] double newValue);
    }
}

