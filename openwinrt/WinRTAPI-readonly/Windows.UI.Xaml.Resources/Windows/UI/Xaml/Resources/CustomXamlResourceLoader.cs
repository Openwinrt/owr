namespace Windows.UI.Xaml.Resources
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both), Version(0x6020000), Composable(typeof(ICustomXamlResourceLoaderFactory), CompositionType.Public, 0x6020000), WebHostHidden, Static(typeof(ICustomXamlResourceLoaderStatics), 0x6020000)]
    public class CustomXamlResourceLoader : ICustomXamlResourceLoader, ICustomXamlResourceLoaderOverrides
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public CustomXamlResourceLoader();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual object GetResource([In] string resourceId, [In] string objectType, [In] string propertyName, [In] string propertyType);

        public static CustomXamlResourceLoader Current { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

