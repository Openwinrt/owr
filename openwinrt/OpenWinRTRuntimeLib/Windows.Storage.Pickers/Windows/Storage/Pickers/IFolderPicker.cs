namespace Windows.Storage.Pickers
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x84f7799, 0xf3fb, 0x400a, 0x99, 0xb1, 0x7b, 0x4a, 0x77, 0x2f, 0xd6, 13), ExclusiveTo(typeof(FolderPicker))]
    internal interface IFolderPicker
    {
        IAsyncOperation<StorageFolder> PickSingleFolderAsync();

        string CommitButtonText { get; [param: In] set; }

        IVector<string> FileTypeFilter { get; }

        string SettingsIdentifier { get; [param: In] set; }

        PickerLocationId SuggestedStartLocation { get; [param: In] set; }

        PickerViewMode ViewMode { get; [param: In] set; }
    }
}

