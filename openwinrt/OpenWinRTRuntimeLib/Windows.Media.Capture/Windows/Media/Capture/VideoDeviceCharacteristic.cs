namespace Windows.Media.Capture
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum VideoDeviceCharacteristic
    {
        AllStreamsIndependent,
        PreviewRecordStreamsIdentical,
        PreviewPhotoStreamsIdentical,
        RecordPhotoStreamsIdentical,
        AllStreamsIdentical
    }
}

