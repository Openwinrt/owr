namespace Windows.Storage.Pickers.Provider
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x9656c1e7, 0x3e56, 0x43cc, 0x8a, 0x39, 0x33, 0xc7, 0x3d, 0x9d, 0x54, 0x2b), ExclusiveTo(typeof(FileSavePickerUI)), Version(0x6020000)]
    internal interface IFileSavePickerUI
    {
        event TypedEventHandler<FileSavePickerUI, object> FileNameChanged;

        event TypedEventHandler<FileSavePickerUI, TargetFileRequestedEventArgs> TargetFileRequested;

        SetFileNameResult TrySetFileName([In] string value);

        IVectorView<string> AllowedFileTypes { get; }

        string FileName { get; }

        string SettingsIdentifier { get; }

        string Title { get; [param: In] set; }
    }
}

