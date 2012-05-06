namespace Windows.UI.Xaml.Documents
{
    using Windows.Foundation.Metadata;

    [WebHostHidden, ExclusiveTo(typeof(Paragraph)), Version(0x6020000), Guid(0xf83ef59a, 0xfa61, 0x4bef, 0xae, 0x33, 11, 10, 0xd7, 0x56, 0xa8, 0x4d)]
    internal interface IParagraph
    {
        InlineCollection Inlines { get; }
    }
}

