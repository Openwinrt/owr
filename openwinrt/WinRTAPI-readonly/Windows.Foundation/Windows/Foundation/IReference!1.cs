namespace Windows.Foundation
{
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Guid(0x61c17706, 0x2d65, 0x11e0, 0x9a, 0xe8, 0xd4, 0x85, 100, 1, 0x54, 0x72), Version(0x6020000)]
    public interface IReference<T> : IPropertyValue
    {
        T Value { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

