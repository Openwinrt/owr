namespace Windows.UI.Xaml.Input
{
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Guid(0x5c0f85f3, 0xf9d8, 0x4220, 0xb6, 0x66, 4, 0x5d, 7, 0x4d, 0x9b, 250), ExclusiveTo(typeof(InputScope)), WebHostHidden, Version(0x6020000)]
    internal interface IInputScope
    {
        IVector<InputScopeName> Names { get; }
    }
}

