namespace Windows.ApplicationModel.Resources
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Static(typeof(IResourceLoaderStatics), 0x6020000), Threading(ThreadingModel.MTA), Activatable(0x6020000), Version(0x6020000), Activatable(typeof(IResourceLoaderFactory), 0x6020000)]
    public sealed class ResourceLoader : IResourceLoader
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ResourceLoader();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ResourceLoader([In] string name);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public string GetString([In] string resource);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static string GetStringForReference([In] Uri uri);
    }
}

