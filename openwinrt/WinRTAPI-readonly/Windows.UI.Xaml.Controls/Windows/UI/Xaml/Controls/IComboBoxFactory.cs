namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(ComboBox)), Windows.Foundation.Metadata.Guid(0xac0d0444, 0xa65b, 0x4abd, 0x86, 0xdf, 0x30, 0x16, 4, 0x9e, 0xfe, 220), WebHostHidden]
    internal interface IComboBoxFactory
    {
        ComboBox CreateInstance([In] object outer, out object inner);
    }
}

