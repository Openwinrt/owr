namespace Windows.ApplicationModel.DataTransfer
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xe22e7749, 0xdd70, 0x446f, 0xae, 0xfc, 0x61, 0xce, 0xe5, 0x9f, 0x65, 0x5e), Version(0x6020000), ExclusiveTo(typeof(HtmlFormatHelper))]
    internal interface IHtmlFormatHelperStatics
    {
        string CreateHtmlFormat([In] string htmlFragment);
        string GetStaticFragment([In] string htmlFormat);
    }
}

