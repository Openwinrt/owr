namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Interop;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0xbf2195a9, 0xf4ea, 0x4336, 0x97, 0x7c, 0xf8, 0xfc, 0xf7, 0x8b, 13, 0x9e), WebHostHidden]
    public interface INavigate
    {
        bool Navigate([In] TypeName sourcePageType);
    }
}

