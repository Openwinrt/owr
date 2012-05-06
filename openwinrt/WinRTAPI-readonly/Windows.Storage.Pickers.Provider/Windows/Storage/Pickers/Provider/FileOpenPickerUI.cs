namespace Windows.Storage.Pickers.Provider
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.Storage;

    [Version(0x6020000)]
    public sealed class FileOpenPickerUI : IFileOpenPickerUI
    {
        public event TypedEventHandler<FileOpenPickerUI, FileRemovedEventArgs> FileRemoved;

        public event TypedEventHandler<FileOpenPickerUI, FileRemovedEventArgs> Windows.Storage.Pickers.Provider.IFileOpenPickerUI.FileRemoved;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public AddFileResult AddFile([In] string id, [In] IStorageFile file);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool CanAddFile([In] IStorageFile file);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool ContainsFile([In] string id);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void RemoveFile([In] string id);

        public IVectorView<string> AllowedFileTypes { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public FileSelectionMode SelectionMode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string SettingsIdentifier { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Title { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IVectorView<string> Windows.Storage.Pickers.Provider.IFileOpenPickerUI.AllowedFileTypes { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public FileSelectionMode Windows.Storage.Pickers.Provider.IFileOpenPickerUI.SelectionMode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Storage.Pickers.Provider.IFileOpenPickerUI.SettingsIdentifier { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Storage.Pickers.Provider.IFileOpenPickerUI.Title { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

