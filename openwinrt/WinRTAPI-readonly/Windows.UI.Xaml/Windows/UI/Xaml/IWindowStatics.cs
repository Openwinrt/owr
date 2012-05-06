namespace Windows.UI.Xaml
{
    using Windows.Foundation.Metadata;

    [WebHostHidden, Guid(0x93328409, 0x4ea1, 0x4afa, 0x83, 220, 12, 0x4e, 0x73, 0xe8, 0x8b, 0xb1), ExclusiveTo(typeof(Window)), Version(0x6020000)]
    internal interface IWindowStatics
    {
        Window Current { get; }
    }
}

