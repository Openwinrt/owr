namespace Windows.Foundation.Collections
{
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0x2b51929, 0xc1c4, 0x4a7e, 0x89, 0x40, 3, 0x12, 0xb5, 0xc1, 0x85, 0)]
    public interface IKeyValuePair<K, V>
    {
        K Key { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        V Value { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

