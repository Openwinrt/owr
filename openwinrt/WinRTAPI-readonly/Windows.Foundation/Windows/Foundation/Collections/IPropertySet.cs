namespace Windows.Foundation.Collections
{
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0x8a43ed9f, 0xf4e6, 0x4421, 0xac, 0xf9, 0x1d, 0xab, 0x29, 0x86, 130, 12), HasVariant]
    public interface IPropertySet : IObservableMap<string, object>, IMap<string, object>, IIterable<IKeyValuePair<string, object>>
    {
    }
}

