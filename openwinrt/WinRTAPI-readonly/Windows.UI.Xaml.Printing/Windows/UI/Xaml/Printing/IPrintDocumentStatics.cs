namespace Windows.UI.Xaml.Printing
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [ExclusiveTo(typeof(PrintDocument)), Version(0x6020000), WebHostHidden, Guid(0xfd970a3c, 0xb152, 0x49e0, 0xa6, 0xbd, 0x6a, 0xa6, 0x47, 0x7e, 0x43, 0xc7)]
    internal interface IPrintDocumentStatics
    {
        DependencyProperty DocumentSourceProperty { get; }
    }
}

