namespace Windows.Foundation.Collections
{
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0x9939f4df, 0x50a, 0x4c0f, 170, 0x60, 0x77, 7, 0x5f, 0x9c, 0x47, 0x77)]
    public interface IMapChangedEventArgs<K>
    {
        Windows.Foundation.Collections.CollectionChange CollectionChange { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        K Key { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

