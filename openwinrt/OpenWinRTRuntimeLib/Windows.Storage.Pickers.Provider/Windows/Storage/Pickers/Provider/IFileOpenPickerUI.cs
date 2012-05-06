namespace Windows.Storage.Pickers.Provider
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.Storage;

    [Windows.Foundation.Metadata.Guid(0xdda45a10, 0xf9d4, 0x40c4, 0x8a, 0xf5, 0xc5, 0xb6, 0xb5, 0xa6, 0x1d, 0x1d), ExclusiveTo(typeof(FileOpenPickerUI)), Version(0x6020000)]
    internal interface IFileOpenPickerUI
    {
        event TypedEventHandler<FileOpenPickerUI, FileRemovedEventArgs> FileRemoved;

        AddFileResult AddFile([In] string id, [In] IStorageFile file);
        bool CanAddFile([In] IStorageFile file);
        bool ContainsFile([In] string id);
        void RemoveFile([In] string id);

        IVectorView<string> AllowedFileTypes { get; }

        FileSelectionMode SelectionMode { get; }

        string SettingsIdentifier { get; }

        string Title { get; [param: In] set; }
    }
}

