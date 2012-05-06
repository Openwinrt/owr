namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(ContentControl)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0xab017b19, 0x196e, 0x4ed5, 0xa2, 0x7f, 0x55, 0xc5, 0x8f, 0xb1, 0x67, 0x3f), WebHostHidden]
    internal interface IContentControlFactory
    {
        ContentControl CreateInstance([In] object outer, out object inner);
    }
}

