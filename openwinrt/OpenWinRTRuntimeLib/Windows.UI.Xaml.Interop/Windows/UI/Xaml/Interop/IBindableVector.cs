namespace Windows.UI.Xaml.Interop
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Version(0x6020000), Windows.Foundation.Metadata.Guid(0x393de7de, 0x6fd0, 0x4c0d, 0xbb, 0x71, 0x47, 0x24, 0x4a, 0x11, 0x3e, 0x93)]
    public interface IBindableVector : IBindableIterable
    {
        void Append([In] object value);
        void Clear();
        object GetAt([In] uint index);
        IBindableVectorView GetView();
        bool IndexOf([In] object value, out uint index);
        void InsertAt([In] uint index, [In] object value);
        void RemoveAt([In] uint index);
        void RemoveAtEnd();
        void SetAt([In] uint index, [In] object value);

        uint Size { get; }
    }
}

