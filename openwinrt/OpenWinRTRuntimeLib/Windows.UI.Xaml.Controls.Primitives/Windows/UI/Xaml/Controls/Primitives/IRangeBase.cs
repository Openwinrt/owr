namespace Windows.UI.Xaml.Controls.Primitives
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(RangeBase)), WebHostHidden, Windows.Foundation.Metadata.Guid(0xfa002c1a, 0x494e, 0x46cf, 0x91, 0xd4, 0xe1, 0x4a, 0x8d, 0x79, 0x86, 0x75), Version(0x6020000)]
    internal interface IRangeBase
    {
        event RangeBaseValueChangedEventHandler ValueChanged;

        double LargeChange { get; [param: In] set; }

        double Maximum { get; [param: In] set; }

        double Minimum { get; [param: In] set; }

        double SmallChange { get; [param: In] set; }

        double Value { get; [param: In] set; }
    }
}

