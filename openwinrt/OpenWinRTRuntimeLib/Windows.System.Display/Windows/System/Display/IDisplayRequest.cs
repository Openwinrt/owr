namespace Windows.System.Display
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0xe5732044, 0xf49f, 0x4b60, 0x8d, 0xd4, 0x5e, 0x7e, 0x3a, 0x63, 0x2a, 0xc0), ExclusiveTo(typeof(DisplayRequest))]
    internal interface IDisplayRequest
    {
        void RequestActive();
        void RequestRelease();
    }
}

