namespace Windows.UI.Xaml
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(PropertyMetadata)), Guid(0x814ef30d, 0x8d18, 0x448a, 0x86, 0x44, 0xf2, 0xcb, 0x51, 0xe7, 3, 0x80), WebHostHidden]
    internal interface IPropertyMetadata
    {
        Windows.UI.Xaml.CreateDefaultValueCallback CreateDefaultValueCallback { get; }

        object DefaultValue { get; }
    }
}

