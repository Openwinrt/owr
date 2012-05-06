namespace Windows.UI.Xaml.Documents
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x9839d4a9, 0x2af, 0x4811, 170, 0x15, 0x6b, 0xef, 0x3a, 0xca, 0xc9, 0x7a), WebHostHidden, ExclusiveTo(typeof(Span))]
    internal interface ISpan
    {
        InlineCollection Inlines { get; [param: In] set; }
    }
}

