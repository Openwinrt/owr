namespace Windows.UI.Xaml.Markup
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0xf6790987, 0xe6e5, 0x47f2, 0x92, 0xc6, 0xec, 0xcc, 0xe4, 0xba, 0x15, 0x9a), WebHostHidden]
    public interface IComponentConnector
    {
        void Connect([In] int connectionId, [In] object target);
    }
}

