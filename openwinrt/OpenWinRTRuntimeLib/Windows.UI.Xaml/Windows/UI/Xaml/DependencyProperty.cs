namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Interop;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both), WebHostHidden, Version(0x6020000), Static(typeof(IDependencyPropertyStatics), 0x6020000)]
    public sealed class DependencyProperty : IDependencyProperty
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public PropertyMetadata GetMetadata([In] TypeName forType);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static DependencyProperty Register([In] string name, [In] TypeName propertyType, [In] TypeName ownerType, [In] PropertyMetadata typeMetadata);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static DependencyProperty RegisterAttached([In] string name, [In] TypeName propertyType, [In] TypeName ownerType, [In] PropertyMetadata defaultMetadata);

        public static object UnsetValue { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

