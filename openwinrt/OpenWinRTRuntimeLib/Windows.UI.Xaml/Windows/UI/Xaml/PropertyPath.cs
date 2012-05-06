namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Activatable(typeof(IPropertyPathFactory), 0x6020000), Threading(ThreadingModel.Both)]
    public sealed class PropertyPath : DependencyObject, IPropertyPath
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public PropertyPath([In] string path);

        public string Path { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.UI.Xaml.IPropertyPath.Path { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

