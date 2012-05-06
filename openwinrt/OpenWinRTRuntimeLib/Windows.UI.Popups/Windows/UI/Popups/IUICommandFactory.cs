namespace Windows.UI.Popups
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0xa21a8189, 0x26b0, 0x4676, 0xae, 0x94, 0x54, 4, 0x1b, 0xc1, 0x25, 0xe8), ExclusiveTo(typeof(UICommand))]
    internal interface IUICommandFactory
    {
        UICommand Create([In] string label);
        UICommand CreateWithHandler([In] string label, [In] UICommandInvokedHandler action);
        UICommand CreateWithHandlerAndId([In] string label, [In] UICommandInvokedHandler action, [In, Variant] object commandId);
    }
}

