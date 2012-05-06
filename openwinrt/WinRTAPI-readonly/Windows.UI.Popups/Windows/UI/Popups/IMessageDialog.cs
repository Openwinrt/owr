namespace Windows.UI.Popups
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x46962176, 0x76b9, 0x4c9d, 0xa4, 0x21, 0x99, 0x74, 0x10, 0xd6, 0x9d, 0x3b), ExclusiveTo(typeof(MessageDialog))]
    internal interface IMessageDialog
    {
        IAsyncOperation<IUICommand> ShowAsync();

        uint CancelCommandIndex { get; [param: In] set; }

        IVector<IUICommand> Commands { get; }

        string Content { get; [param: In] set; }

        uint DefaultCommandIndex { get; [param: In] set; }

        string Title { get; [param: In] set; }
    }
}

