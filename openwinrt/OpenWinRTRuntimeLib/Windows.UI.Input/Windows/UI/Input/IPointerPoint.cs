namespace Windows.UI.Input
{
    using System;
    using Windows.Devices.Input;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0xe995317d, 0x7296, 0x42d9, 130, 0x33, 0xc5, 190, 0x73, 0xb7, 0x4a, 0x4a), ExclusiveTo(typeof(PointerPoint))]
    internal interface IPointerPoint
    {
        uint FrameId { get; }

        bool IsInContact { get; }

        Windows.Devices.Input.PointerDevice PointerDevice { get; }

        uint PointerId { get; }

        Point Position { get; }

        PointerPointProperties Properties { get; }

        Point RawPosition { get; }

        ulong Timestamp { get; }
    }
}

