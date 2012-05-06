namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), WebHostHidden, ExclusiveTo(typeof(FrameworkTemplate)), Windows.Foundation.Metadata.Guid(0x1a78a0a5, 0x937d, 0x46d4, 0x83, 0x2b, 0x94, 0xff, 20, 0xda, 0xb0, 0x61)]
    internal interface IFrameworkTemplateFactory
    {
        FrameworkTemplate CreateInstance([In] object outer, out object inner);
    }
}

