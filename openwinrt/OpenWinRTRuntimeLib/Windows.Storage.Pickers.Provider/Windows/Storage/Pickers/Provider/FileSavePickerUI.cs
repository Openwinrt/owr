namespace Windows.Storage.Pickers.Provider
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class FileSavePickerUI : IFileSavePickerUI
    {
        public event TypedEventHandler<FileSavePickerUI, object> FileNameChanged;

        public event TypedEventHandler<FileSavePickerUI, TargetFileRequestedEventArgs> TargetFileRequested;

        public event TypedEventHandler<FileSavePickerUI, object> Windows.Storage.Pickers.Provider.IFileSavePickerUI.FileNameChanged;

        public event TypedEventHandler<FileSavePickerUI, TargetFileRequestedEventArgs> Windows.Storage.Pickers.Provider.IFileSavePickerUI.TargetFileRequested;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public SetFileNameResult TrySetFileName([In] string value);

        public IVectorView<string> AllowedFileTypes { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string FileName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string SettingsIdentifier { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Title { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IVectorView<string> Windows.Storage.Pickers.Provider.IFileSavePickerUI.AllowedFileTypes { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Storage.Pickers.Provider.IFileSavePickerUI.FileName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Storage.Pickers.Provider.IFileSavePickerUI.SettingsIdentifier { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Storage.Pickers.Provider.IFileSavePickerUI.Title { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

