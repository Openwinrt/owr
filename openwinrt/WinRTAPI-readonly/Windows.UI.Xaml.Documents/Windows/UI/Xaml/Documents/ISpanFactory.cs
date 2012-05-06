namespace Windows.UI.Xaml.Documents
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x5b916f5c, 0xcd2d, 0x40c0, 0x95, 0x6a, 0x38, 100, 0x48, 50, 0x2f, 0x79), WebHostHidden, ExclusiveTo(typeof(Span))]
    internal interface ISpanFactory
    {
        Span CreateInstance([In] object outer, out object inner);
    }
}

