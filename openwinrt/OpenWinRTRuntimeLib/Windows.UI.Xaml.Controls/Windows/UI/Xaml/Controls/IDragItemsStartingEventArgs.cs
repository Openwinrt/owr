namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.ApplicationModel.DataTransfer;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x71cf215c, 0xdaed, 0x4783, 170, 0x11, 220, 0x57, 0x4d, 0x27, 0x13, 0xe9), ExclusiveTo(typeof(DragItemsStartingEventArgs)), WebHostHidden, Version(0x6020000)]
    internal interface IDragItemsStartingEventArgs
    {
        bool Cancel { get; [param: In] set; }

        DataPackage Data { get; }

        IVector<object> Items { get; }
    }
}

