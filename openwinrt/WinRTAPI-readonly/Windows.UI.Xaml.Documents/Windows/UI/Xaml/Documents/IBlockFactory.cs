namespace Windows.UI.Xaml.Documents
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(Block)), Windows.Foundation.Metadata.Guid(0x7110532, 0x4f59, 0x4f3b, 0x9c, 0xe5, 0x25, 120, 0x4c, 0x43, 5, 7), Version(0x6020000), WebHostHidden]
    internal interface IBlockFactory
    {
        Block CreateInstance([In] object outer, out object inner);
    }
}

