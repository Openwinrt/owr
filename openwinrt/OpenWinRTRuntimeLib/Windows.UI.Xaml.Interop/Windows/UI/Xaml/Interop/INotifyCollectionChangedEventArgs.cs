namespace Windows.UI.Xaml.Interop
{
    using System;
    using Windows.Foundation.Metadata;

    [Guid(0x4cf68d33, 0xe3f2, 0x4964, 0xb8, 0x5e, 0x94, 0x5b, 0x4f, 0x7e, 0x2f, 0x21), ExclusiveTo(typeof(NotifyCollectionChangedEventArgs)), WebHostHidden, Version(0x6020000)]
    internal interface INotifyCollectionChangedEventArgs
    {
        NotifyCollectionChangedAction Action { get; }

        IBindableVector NewItems { get; }

        int NewStartingIndex { get; }

        IBindableVector OldItems { get; }

        int OldStartingIndex { get; }
    }
}

