namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Version(0x6020000), Windows.Foundation.Metadata.Guid(0xc1b81cc0, 0x57cd, 0x4f2f, 0xb0, 0xa9, 0xe1, 0x80, 0x1b, 40, 0xf7, 0x6b), ExclusiveTo(typeof(PropertyMetadata))]
    internal interface IPropertyMetadataFactory
    {
        PropertyMetadata CreateInstanceWithDefaultValue([In] object defaultValue, [In] object outer, out object inner);
        PropertyMetadata CreateInstanceWithDefaultValueAndCallback([In] object defaultValue, [In] PropertyChangedCallback propertyChangedCallback, [In] object outer, out object inner);
    }
}

