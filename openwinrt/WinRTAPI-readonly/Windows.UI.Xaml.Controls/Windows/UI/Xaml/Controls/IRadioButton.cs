namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x325c44e0, 0x9a03, 0x4bf3, 0xab, 0xd6, 0x6f, 0xbb, 70, 0xc9, 0xa4, 0x86), WebHostHidden, ExclusiveTo(typeof(RadioButton)), Version(0x6020000)]
    internal interface IRadioButton
    {
        string GroupName { get; [param: In] set; }
    }
}

