namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Threading(ThreadingModel.Both), Composable(typeof(IResourceDictionaryFactory), CompositionType.Public, 0x6020000), WebHostHidden, Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public class ResourceDictionary : DependencyObject, IResourceDictionary, IMap<object, object>, IIterable<IKeyValuePair<object, object>>
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ResourceDictionary();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Clear();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IIterator<IKeyValuePair<object, object>> First();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IMapView<object, object> GetView();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool HasKey([In] object key);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool Insert([In] object key, [In] object value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public object Lookup([In] object key);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Remove([In] object key);

        public IVector<ResourceDictionary> MergedDictionaries { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Size { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Uri Source { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IMap<object, object> ThemeDictionaries { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVector<ResourceDictionary> Windows.UI.Xaml.IResourceDictionary.MergedDictionaries { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Uri Windows.UI.Xaml.IResourceDictionary.Source { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IMap<object, object> Windows.UI.Xaml.IResourceDictionary.ThemeDictionaries { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

