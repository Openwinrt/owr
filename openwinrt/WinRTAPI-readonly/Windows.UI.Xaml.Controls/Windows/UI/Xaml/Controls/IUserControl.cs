namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Windows.Foundation.Metadata.Guid(0xa7a69ec9, 0xea35, 0x4679, 0xbf, 0x29, 0xf4, 240, 0x92, 0x86, 0xd3, 20), Version(0x6020000), ExclusiveTo(typeof(UserControl)), WebHostHidden]
    internal interface IUserControl
    {
        UIElement Content { get; [param: In] set; }
    }
}

