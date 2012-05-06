namespace Windows.UI.WebUI
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x23f12c25, 0xe2f7, 0x4741, 0xbc, 0x9c, 0x39, 0x45, 0x95, 0xde, 0x24, 220), Version(0x6020000)]
    public interface IWebUIBackgroundTaskInstance
    {
        bool Succeeded { get; [param: In] set; }
    }
}

