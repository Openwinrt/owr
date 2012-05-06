namespace Windows.UI.Xaml.Controls.Primitives
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Windows.Foundation.Metadata.Guid(0x541c8d6c, 0x283, 0x4581, 0xb9, 0x45, 0x2a, 100, 0xc2, 0x8a, 6, 70), ExclusiveTo(typeof(SelectorItem)), Version(0x6020000)]
    internal interface ISelectorItem
    {
        bool IsSelected { get; [param: In] set; }
    }
}

