namespace Windows.UI.Xaml.Controls.Primitives
{
    using System;
    using Windows.Foundation.Metadata;

    [WebHostHidden, ExclusiveTo(typeof(RangeBaseValueChangedEventArgs)), Guid(0xa1921777, 0xd5c1, 0x4f9c, 0xa7, 0xb0, 4, 1, 0xb7, 230, 220, 0x5c), Version(0x6020000)]
    internal interface IRangeBaseValueChangedEventArgs
    {
        double NewValue { get; }

        double OldValue { get; }
    }
}

