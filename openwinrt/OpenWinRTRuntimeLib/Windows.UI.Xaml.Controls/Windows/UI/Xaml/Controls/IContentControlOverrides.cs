namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [ExclusiveTo(typeof(ContentControl)), WebHostHidden, Version(0x6020000), Windows.Foundation.Metadata.Guid(0x5f4c0b10, 0xe38e, 0x4b5d, 190, 0x1a, 0x5e, 0xd0, 0x42, 70, 0xa6, 0x35)]
    internal interface IContentControlOverrides
    {
        void OnContentChanged([In] object oldContent, [In] object newContent);
        void OnContentTemplateChanged([In] DataTemplate oldContentTemplate, [In] DataTemplate newContentTemplate);
        void OnContentTemplateSelectorChanged([In] DataTemplateSelector oldContentTemplateSelector, [In] DataTemplateSelector newContentTemplateSelector);
    }
}

