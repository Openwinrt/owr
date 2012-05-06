namespace Windows.System.Threading
{
    using System;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Version(0x6020000), Guid(0x594ebe78, 0x55ea, 0x4a88, 0xa5, 13, 0x34, 2, 0xae, 0x1f, 0x9c, 0xf2)]
    public interface IThreadPoolTimer
    {
        void Cancel();

        Windows.Foundation.TimeSpan Delay { get; }

        Windows.Foundation.TimeSpan Period { get; }
    }
}

