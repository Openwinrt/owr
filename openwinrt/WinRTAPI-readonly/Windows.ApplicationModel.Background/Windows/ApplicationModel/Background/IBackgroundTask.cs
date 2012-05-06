namespace Windows.ApplicationModel.Background
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x7d13d534, 0xfd12, 0x43ce, 140, 0x22, 0xea, 0x1f, 0xf1, 60, 6, 0xdf), WebHostHidden]
    public interface IBackgroundTask
    {
        void Run([In] IBackgroundTaskInstance taskInstance);
    }
}

