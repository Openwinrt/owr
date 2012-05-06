namespace Windows.UI.Xaml.Data
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Windows.Foundation.Metadata.Guid(0x6dcc9c03, 0xe0c7, 0x4eee, 0x8e, 0xa9, 0x37, 0xe3, 0x40, 110, 0xeb, 0x1c), ExclusiveTo(typeof(PropertyChangedEventArgs)), Version(0x6020000)]
    internal interface IPropertyChangedEventArgsFactory
    {
        PropertyChangedEventArgs CreateInstance([In] string name, [In] object outer, out object inner);
    }
}

