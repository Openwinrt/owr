namespace Windows.Storage.Pickers
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class FilePickerFileTypesOrderedMap : IMap<string, IVector<string>>, IIterable<IKeyValuePair<string, IVector<string>>>
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Clear();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IIterator<IKeyValuePair<string, IVector<string>>> First();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IMapView<string, IVector<string>> GetView();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool HasKey([In] string key);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool Insert([In] string key, [In] IVector<string> value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IVector<string> Lookup([In] string key);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Remove([In] string key);

        public uint Size { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

