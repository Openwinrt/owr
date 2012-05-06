namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(HyperlinkButton)), Windows.Foundation.Metadata.Guid(0x43521bad, 0x4e97, 0x4da9, 0xa6, 0x4d, 0x93, 0x5d, 0xfd, 140, 0xed, 0xf2), WebHostHidden, Version(0x6020000)]
    internal interface IHyperlinkButtonFactory
    {
        HyperlinkButton CreateInstance([In] object outer, out object inner);
    }
}

