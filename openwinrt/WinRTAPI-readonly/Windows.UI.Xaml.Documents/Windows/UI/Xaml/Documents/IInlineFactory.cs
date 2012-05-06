namespace Windows.UI.Xaml.Documents
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x4058acd1, 0x2f90, 0x4b8f, 0x99, 0xdd, 0x42, 0x18, 0xef, 0x5f, 3, 0xde), WebHostHidden, Version(0x6020000), ExclusiveTo(typeof(Inline))]
    internal interface IInlineFactory
    {
        Inline CreateInstance([In] object outer, out object inner);
    }
}

