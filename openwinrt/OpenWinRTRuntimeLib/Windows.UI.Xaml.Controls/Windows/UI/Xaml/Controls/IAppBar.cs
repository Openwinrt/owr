namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x7b0fc253, 0x86a5, 0x4b43, 0x98, 0x72, 11, 0x8a, 0x62, 0x34, 0xb7, 0x4b), ExclusiveTo(typeof(AppBar)), WebHostHidden]
    internal interface IAppBar
    {
        event Windows.Foundation.EventHandler<object> Closed;

        event Windows.Foundation.EventHandler<object> Opened;

        bool IsOpen { get; [param: In] set; }

        bool IsSticky { get; [param: In] set; }
    }
}

