namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(ComboBoxItem)), Windows.Foundation.Metadata.Guid(0x8fffe867, 0xd94c, 0x4e87, 0x8f, 0xc4, 110, 0xbc, 0xd6, 60, 90, 0xc2), WebHostHidden, Version(0x6020000)]
    internal interface IComboBoxItemFactory
    {
        ComboBoxItem CreateInstance([In] object outer, out object inner);
    }
}

