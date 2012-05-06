namespace Windows.UI.Xaml.Hosting
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xaafb84cd, 0x9f6d, 0x4f80, 0xac, 0x2c, 14, 0x6c, 0xb9, 0xf3, 0x16, 0x59), Version(0x6020000), WebHostHidden]
    public interface IXamlUIPresenterHost
    {
        string ResolveFileResource([In] string path);
    }
}

