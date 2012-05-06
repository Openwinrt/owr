namespace Windows.Foundation.Collections
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x5917eb53, 0x50b4, 0x4a0d, 0xb3, 9, 0x65, 0x86, 0x2b, 0x3f, 0x1d, 0xbc), Version(0x6020000)]
    public interface IObservableVector<T> : IVector<T>
    {
        event VectorChangedEventHandler<T> VectorChanged;
    }
}

