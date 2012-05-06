namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(DataTemplateKey)), Windows.Foundation.Metadata.Guid(0xe96b2959, 0xd982, 0x4152, 0x91, 0xcb, 0xde, 14, 0x4d, 0xfd, 0x76, 0x93), WebHostHidden, Version(0x6020000)]
    internal interface IDataTemplateKeyFactory
    {
        DataTemplateKey CreateInstance([In] object outer, out object inner);
        DataTemplateKey CreateInstanceWithType([In] object dataType, [In] object outer, out object inner);
    }
}

