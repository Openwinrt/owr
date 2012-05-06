namespace Windows.Graphics.Printing
{
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Guid(0x62e69e23, 0x9a1e, 0x4336, 0xb7, 0x4f, 60, 0xc7, 0xf4, 0xcf, 0xf7, 9), Version(0x6020000)]
    public interface IPrintTaskOptionsCoreUIConfiguration
    {
        IVector<string> DisplayedOptions { get; }
    }
}

