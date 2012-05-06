namespace Windows.UI.Xaml.Controls.Primitives
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(SelectorItem)), Version(0x6020000), WebHostHidden, Windows.Foundation.Metadata.Guid(0xb9363945, 0xc86a, 0x4b1e, 0x94, 0x40, 0x18, 0x79, 0x37, 0x8d, 0x53, 0x13)]
    internal interface ISelectorItemFactory
    {
        SelectorItem CreateInstance([In] object outer, out object inner);
    }
}

