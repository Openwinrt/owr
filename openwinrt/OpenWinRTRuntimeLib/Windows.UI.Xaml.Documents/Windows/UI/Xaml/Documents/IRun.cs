namespace Windows.UI.Xaml.Documents
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Windows.Foundation.Metadata.Guid(0x59553c83, 0xe14, 0x49bd, 0xb8, 0x4b, 0xc5, 0x26, 0xf3, 3, 0x43, 0x49), Version(0x6020000), WebHostHidden, ExclusiveTo(typeof(Run))]
    internal interface IRun
    {
        Windows.UI.Xaml.FlowDirection FlowDirection { get; [param: In] set; }

        string Text { get; [param: In] set; }
    }
}

