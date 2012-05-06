namespace Windows.UI.Popups
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x4ff93a75, 0x4145, 0x47ff, 0xac, 0x7f, 0xdf, 0xf1, 0xc1, 250, 0x5b, 15)]
    public interface IUICommand
    {
        object Id { [return: Variant] get; [param: In, Variant] set; }

        UICommandInvokedHandler Invoked { get; [param: In] set; }

        string Label { get; [param: In] set; }
    }
}

