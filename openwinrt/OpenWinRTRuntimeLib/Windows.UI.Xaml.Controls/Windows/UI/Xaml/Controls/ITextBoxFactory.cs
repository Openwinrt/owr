namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x710e4278, 0x8529, 0x47d3, 0x8d, 0x8e, 0x30, 0x7e, 0x34, 0xcf, 240, 0x81), ExclusiveTo(typeof(TextBox)), Version(0x6020000), WebHostHidden]
    internal interface ITextBoxFactory
    {
        TextBox CreateInstance([In] object outer, out object inner);
    }
}

