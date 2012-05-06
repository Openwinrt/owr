namespace Windows.UI.Xaml.Input
{
    using System;
    using Windows.Devices.Input;
    using Windows.Foundation.Metadata;

    [Guid(0x5ee8f39f, 0x747d, 0x4171, 0x90, 230, 0xcd, 0x37, 0xa9, 0xdf, 0xfb, 0x11), ExclusiveTo(typeof(Pointer)), Version(0x6020000), WebHostHidden]
    internal interface IPointer
    {
        bool IsInContact { get; }

        bool IsInRange { get; }

        Windows.Devices.Input.PointerDeviceType PointerDeviceType { get; }

        uint PointerId { get; }
    }
}

