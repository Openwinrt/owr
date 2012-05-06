namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), WebHostHidden, Windows.Foundation.Metadata.Guid(0x4f016541, 0xbcfe, 0x4a22, 0x89, 50, 0xc9, 20, 0x98, 0x1c, 0x22, 0x40), ExclusiveTo(typeof(ComboBox))]
    internal interface IComboBoxOverrides
    {
        void OnDropDownClosed([In] object e);
        void OnDropDownOpened([In] object e);
    }
}

