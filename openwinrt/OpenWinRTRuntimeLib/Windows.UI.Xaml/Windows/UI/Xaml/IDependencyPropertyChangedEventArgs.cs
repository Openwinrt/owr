namespace Windows.UI.Xaml
{
    using System;
    using Windows.Foundation.Metadata;

    [Guid(0x81212c2b, 0x24d0, 0x4957, 0xab, 0xc3, 0x22, 0x44, 0x70, 0xa9, 0x3a, 0x4e), Version(0x6020000), ExclusiveTo(typeof(DependencyPropertyChangedEventArgs)), WebHostHidden]
    internal interface IDependencyPropertyChangedEventArgs
    {
        object NewValue { get; }

        object OldValue { get; }

        DependencyProperty Property { get; }
    }
}

