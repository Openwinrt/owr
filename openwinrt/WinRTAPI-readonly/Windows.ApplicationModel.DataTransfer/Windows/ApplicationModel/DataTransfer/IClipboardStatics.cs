namespace Windows.ApplicationModel.DataTransfer
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xc627e291, 0x34e2, 0x4963, 0x8e, 0xed, 0x93, 0xcb, 0xb0, 0xea, 0x3d, 0x70), ExclusiveTo(typeof(Clipboard)), Version(0x6020000)]
    internal interface IClipboardStatics
    {
        event Windows.Foundation.EventHandler<object> ContentChanged;

        void Clear();
        void Flush();
        DataPackageView GetContent();
        void SetContent([In] DataPackage content);
    }
}

