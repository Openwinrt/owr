namespace Windows.Foundation.Collections
{
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0xfaa585ea, 0x6214, 0x4217, 0xaf, 0xda, 0x7f, 70, 0xde, 0x58, 0x69, 0xb3)]
    public interface IIterable<T>
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        IIterator<T> First();
    }
}

