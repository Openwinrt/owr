namespace Windows.UI.Xaml.Printing
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xfb87b18f, 0x2606, 0x4a2f, 0x99, 0xd4, 0xa7, 0xcd, 0xbc, 0x35, 0xd7, 0xc7), ExclusiveTo(typeof(PrintDocument)), WebHostHidden, Version(0x6020000)]
    internal interface IPrintDocumentFactory
    {
        PrintDocument CreateInstance([In] object outer, out object inner);
    }
}

