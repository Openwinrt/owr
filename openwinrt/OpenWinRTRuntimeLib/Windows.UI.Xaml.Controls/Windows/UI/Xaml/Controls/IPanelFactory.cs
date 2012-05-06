namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(Panel)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0xeee68111, 0xc7cc, 0x433f, 0x95, 0xcd, 0xd6, 0x30, 0xc3, 0x43, 2, 0xdd), WebHostHidden]
    internal interface IPanelFactory
    {
        Panel CreateInstance([In] object outer, out object inner);
    }
}

