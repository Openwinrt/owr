namespace Windows.UI.Core
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x9ffdf7f5, 0xb8c9, 0x4ef0, 0xb7, 210, 0x1d, 230, 0x26, 0x56, 0x1f, 200), Version(0x6020000), WebHostHidden]
    public interface ICoreAcceleratorKeys
    {
        event TypedEventHandler<CoreDispatcher, AcceleratorKeyEventArgs> AcceleratorKeyActivated;
    }
}

