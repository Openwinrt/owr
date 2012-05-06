namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xd3ca3d42, 0x9b1, 0x49d5, 0x88, 0x91, 0xe7, 0xb5, 100, 0x8e, 2, 0xa2), WebHostHidden, ExclusiveTo(typeof(Setter)), Version(0x6020000)]
    internal interface ISetterFactory
    {
        Setter CreateInstance([In] DependencyProperty property, [In] object value);
    }
}

