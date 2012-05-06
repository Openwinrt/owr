namespace Windows.Foundation.Collections
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xc051752, 0x9fbf, 0x4c70, 170, 12, 14, 0x4c, 130, 0xd9, 0xa7, 0x61), Version(0x6020000)]
    public delegate void VectorChangedEventHandler<T>([In] IObservableVector<T> sender, [In] IVectorChangedEventArgs @event);
}

