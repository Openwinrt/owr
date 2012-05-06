namespace Windows.Media.Capture
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x3b0d5e34, 0x3906, 0x4b7d, 0x94, 0x6c, 0x7b, 0xde, 0x84, 0x44, 0x99, 0xae), Version(0x6020000), ExclusiveTo(typeof(CameraOptionsUI))]
    internal interface ICameraOptionsUIStatics
    {
        void Show([In] MediaCapture mediaCapture);
    }
}

