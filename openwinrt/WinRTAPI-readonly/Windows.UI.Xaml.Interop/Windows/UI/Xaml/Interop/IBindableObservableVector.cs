namespace Windows.UI.Xaml.Interop
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Windows.Foundation.Metadata.Guid(0xfe1eb536, 0x7e7f, 0x4f90, 0xac, 0x9a, 0x47, 0x49, 0x84, 170, 0xe5, 0x12), Version(0x6020000)]
    public interface IBindableObservableVector : IBindableVector, IBindableIterable
    {
        event BindableVectorChangedEventHandler VectorChanged;
    }
}

