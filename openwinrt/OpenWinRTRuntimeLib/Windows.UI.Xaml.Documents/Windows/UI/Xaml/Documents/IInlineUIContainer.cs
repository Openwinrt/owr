namespace Windows.UI.Xaml.Documents
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Windows.Foundation.Metadata.Guid(0x1416ce81, 0x28ee, 0x452e, 0xb1, 0x21, 0x5f, 0xc4, 0xf6, 11, 0x86, 0xa6), ExclusiveTo(typeof(InlineUIContainer)), Version(0x6020000), WebHostHidden]
    internal interface IInlineUIContainer
    {
        UIElement Child { get; [param: In] set; }
    }
}

