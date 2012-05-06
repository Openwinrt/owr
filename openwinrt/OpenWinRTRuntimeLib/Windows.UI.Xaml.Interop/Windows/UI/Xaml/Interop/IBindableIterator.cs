namespace Windows.UI.Xaml.Interop
{
    using System;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Version(0x6020000), Guid(0x6a1d6c07, 0x76d, 0x49f2, 0x83, 20, 0xf5, 0x2c, 0x9c, 0x9a, 0x83, 0x31)]
    public interface IBindableIterator
    {
        bool MoveNext();

        object Current { get; }

        bool HasCurrent { get; }
    }
}

