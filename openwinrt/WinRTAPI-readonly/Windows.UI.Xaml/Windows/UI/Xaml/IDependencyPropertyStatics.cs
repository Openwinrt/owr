namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Interop;

    [WebHostHidden, Version(0x6020000), Windows.Foundation.Metadata.Guid(0x49e5f28f, 0x8259, 0x4d5c, 170, 0xe0, 0x83, 0xd5, 0x6d, 0xbb, 0x68, 0xd9), ExclusiveTo(typeof(DependencyProperty))]
    internal interface IDependencyPropertyStatics
    {
        DependencyProperty Register([In] string name, [In] TypeName propertyType, [In] TypeName ownerType, [In] PropertyMetadata typeMetadata);
        DependencyProperty RegisterAttached([In] string name, [In] TypeName propertyType, [In] TypeName ownerType, [In] PropertyMetadata defaultMetadata);

        object UnsetValue { get; }
    }
}

