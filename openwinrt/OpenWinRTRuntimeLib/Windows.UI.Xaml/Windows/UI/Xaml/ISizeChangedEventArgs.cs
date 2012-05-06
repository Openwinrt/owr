namespace Windows.UI.Xaml
{
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Guid(0xd5312e60, 0x5cc1, 0x42a1, 0x92, 12, 0x1a, 0xf4, 0x6b, 0xe2, 0xf9, 0x86), WebHostHidden, ExclusiveTo(typeof(SizeChangedEventArgs)), Version(0x6020000)]
    internal interface ISizeChangedEventArgs
    {
        Size NewSize { get; }

        Size PreviousSize { get; }
    }
}

