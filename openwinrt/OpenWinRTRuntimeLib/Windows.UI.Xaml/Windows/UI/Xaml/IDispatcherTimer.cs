namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Windows.Foundation.Metadata.Guid(0xd160ce46, 0xcd22, 0x4f5f, 140, 0x97, 0x40, 230, 0x1d, 0xa3, 0xe2, 220), Version(0x6020000), ExclusiveTo(typeof(DispatcherTimer))]
    internal interface IDispatcherTimer
    {
        event Windows.Foundation.EventHandler<object> Tick;

        void Start();
        void Stop();

        Windows.Foundation.TimeSpan Interval { get; [param: In] set; }

        bool IsEnabled { get; }
    }
}

