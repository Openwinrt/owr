namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xf003e4e2, 0x7b0f, 0x4f4a, 0x97, 13, 0xae, 0x8a, 14, 170, 0x9b, 0x70), WebHostHidden, ExclusiveTo(typeof(AppBar)), Version(0x6020000)]
    internal interface IAppBarOverrides
    {
        void OnClosed([In] object e);
        void OnOpened([In] object e);
    }
}

