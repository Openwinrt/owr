namespace Windows.UI.Popups
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(MessageDialog)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0x2d161777, 0xa66f, 0x4ea5, 0xbb, 0x87, 0x79, 0x3f, 250, 0x49, 0x41, 0xf2)]
    internal interface IMessageDialogFactory
    {
        MessageDialog Create([In] string content);
        MessageDialog CreateWithTitle([In] string content, [In] string title);
    }
}

