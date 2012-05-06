namespace Windows.ApplicationModel.Activation
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum ActivationKind
    {
        Launch,
        Search,
        ShareTarget,
        File,
        Protocol,
        FileOpenPicker,
        FileSavePicker,
        CachedFileUpdater,
        ContactPicker,
        Device,
        PrintTaskSettings,
        CameraSettings
    }
}

