namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(PropertyMetadata)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0x3b01077a, 0x6e06, 0x45e9, 0x8b, 0x5c, 0xaf, 0x24, 0x34, 0x58, 0xc0, 0x62), WebHostHidden]
    internal interface IPropertyMetadataStatics
    {
        [DefaultOverload, Overload("CreateWithDefaultValue")]
        PropertyMetadata Create([In] object defaultValue);
        [Overload("CreateWithFactory")]
        PropertyMetadata Create([In] CreateDefaultValueCallback createDefaultValueCallback);
        [Overload("CreateWithDefaultValueAndCallback"), DefaultOverload]
        PropertyMetadata Create([In] object defaultValue, [In] PropertyChangedCallback propertyChangedCallback);
        [Overload("CreateWithFactoryAndCallback")]
        PropertyMetadata Create([In] CreateDefaultValueCallback createDefaultValueCallback, [In] PropertyChangedCallback propertyChangedCallback);
    }
}

