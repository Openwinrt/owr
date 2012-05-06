namespace Windows.UI.Xaml.Interop
{
    using Windows.Foundation.Metadata;

    [WebHostHidden, Version(0x6020000), Guid(0x36d2c08, 0xdf29, 0x41af, 0x8a, 0xa2, 0xd7, 0x74, 190, 0x62, 0xba, 0x6f)]
    public interface IBindableIterable
    {
        IBindableIterator First();
    }
}

