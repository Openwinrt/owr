namespace Windows.UI.Xaml.Automation.Provider
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x838a34a8, 0x7d5f, 0x4079, 0xaf, 3, 0xc3, 0xd0, 0x15, 0xe9, 0x34, 0x13), WebHostHidden, Version(0x6020000)]
    public interface IRangeValueProvider
    {
        void SetValue([In] double value);

        bool IsReadOnly { get; }

        double LargeChange { get; }

        double Maximum { get; }

        double Minimum { get; }

        double SmallChange { get; }

        double Value { get; }
    }
}

