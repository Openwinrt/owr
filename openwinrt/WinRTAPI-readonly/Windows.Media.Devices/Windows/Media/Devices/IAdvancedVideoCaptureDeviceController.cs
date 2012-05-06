namespace Windows.Media.Devices
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0xde6ff4d3, 0x2b96, 0x4583, 0x80, 0xab, 0xb5, 0xb0, 0x1d, 0xc6, 0xa8, 0xd7), ExclusiveTo(typeof(VideoDeviceController))]
    internal interface IAdvancedVideoCaptureDeviceController
    {
        [return: Variant]
        object GetDeviceProperty([In] string propertyId);
        void SetDeviceProperty([In] string propertyId, [In, Variant] object propertyValue);
    }
}

