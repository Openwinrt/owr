namespace Windows.UI.Xaml.Interop
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x346dd6e7, 0x976e, 0x4bc3, 0x81, 0x5d, 0xec, 0xe2, 0x43, 0xbc, 15, 0x33), WebHostHidden]
    public interface IBindableVectorView : IBindableIterable
    {
        object GetAt([In] uint index);
        bool IndexOf([In] object value, out uint index);

        uint Size { get; }
    }
}

