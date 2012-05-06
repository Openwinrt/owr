namespace Windows.Graphics.Printing.OptionDetails
{
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0x9a2257bf, 0xfe61, 0x43d8, 0xa2, 0x4f, 0xa3, 0xf6, 0xab, 0x73, 0x20, 0xe7)]
    public interface IPrintItemListOptionDetails : IPrintOptionDetails
    {
        IVectorView<object> Items { [return: HasVariant] get; }
    }
}

