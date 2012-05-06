namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Windows.Foundation.Metadata.Guid(0x2d162925, 0x5966, 0x4bfa, 0x86, 0x38, 0x4d, 0x34, 0x56, 0x89, 0xf6, 0xcf), WebHostHidden, ExclusiveTo(typeof(DataTemplateSelector)), Version(0x6020000)]
    internal interface IDataTemplateSelectorOverrides
    {
        DataTemplate SelectTemplateCore([In] object item, [In] DependencyObject container);
    }
}

