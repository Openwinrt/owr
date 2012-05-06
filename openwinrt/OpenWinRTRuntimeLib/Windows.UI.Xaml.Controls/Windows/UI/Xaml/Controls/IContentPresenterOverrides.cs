namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Windows.Foundation.Metadata.Guid(0xa76339ed, 0x32ff, 0x438b, 170, 0xd5, 0x1d, 0x68, 250, 0xe9, 0x34, 0x26), WebHostHidden, ExclusiveTo(typeof(ContentPresenter)), Version(0x6020000)]
    internal interface IContentPresenterOverrides
    {
        void OnContentTemplateChanged([In] DataTemplate oldContentTemplate, [In] DataTemplate newContentTemplate);
        void OnContentTemplateSelectorChanged([In] DataTemplateSelector oldContentTemplateSelector, [In] DataTemplateSelector newContentTemplateSelector);
    }
}

