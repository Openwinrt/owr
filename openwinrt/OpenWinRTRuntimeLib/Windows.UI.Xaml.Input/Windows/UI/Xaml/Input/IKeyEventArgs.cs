namespace Windows.UI.Xaml.Input
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.System;
    using Windows.UI.Core;

    [Version(0x6020000), ExclusiveTo(typeof(Windows.UI.Xaml.Input.KeyEventArgs)), WebHostHidden, Windows.Foundation.Metadata.Guid(0xd4cd3dfe, 0x4079, 0x42e9, 0xa3, 0x9a, 0x30, 0x95, 0xd3, 240, 0x49, 0xc6)]
    internal interface IKeyEventArgs
    {
        bool Handled { get; [param: In] set; }

        VirtualKey Key { get; }

        CorePhysicalKeyStatus KeyStatus { get; }
    }
}

