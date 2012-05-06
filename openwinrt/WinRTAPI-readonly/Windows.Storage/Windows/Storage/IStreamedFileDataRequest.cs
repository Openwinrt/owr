namespace Windows.Storage
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x1673fcce, 0xdabd, 0x4d50, 190, 0xee, 0x18, 11, 0x8a, 0x81, 0x91, 0xb6), Version(0x6020000)]
    public interface IStreamedFileDataRequest
    {
        void FailAndClose([In] StreamedFileFailureMode failureMode);
    }
}

