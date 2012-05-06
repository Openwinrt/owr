namespace Windows.UI.Xaml.Controls.Primitives
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x389b7c71, 0x5220, 0x42b2, 0x99, 0x92, 0x26, 0x90, 0xc1, 0xa6, 0x70, 0x30), Version(0x6020000), ExclusiveTo(typeof(RangeBase)), WebHostHidden]
    internal interface IRangeBaseFactory
    {
        RangeBase CreateInstance([In] object outer, out object inner);
    }
}

