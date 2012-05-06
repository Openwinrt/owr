namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [WebHostHidden, Windows.Foundation.Metadata.Guid(0xa907d496, 0x46a0, 0x4cd7, 0x8d, 190, 0xf9, 0xa5, 0x81, 0xdf, 0x60, 0xb1), Version(0x6020000), ExclusiveTo(typeof(DataTemplateSelector))]
    internal interface IDataTemplateSelector
    {
        DataTemplate SelectTemplate([In] object item, [In] DependencyObject container);
    }
}

