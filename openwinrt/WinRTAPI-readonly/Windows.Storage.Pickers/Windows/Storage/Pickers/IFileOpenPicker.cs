namespace Windows.Storage.Pickers
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x2ca8278a, 0x12c5, 0x4c5f, 0x89, 0x77, 0x94, 0x54, 0x77, 0x93, 0xc2, 0x41), ExclusiveTo(typeof(FileOpenPicker)), Version(0x6020000)]
    internal interface IFileOpenPicker
    {
        IAsyncOperation<IVectorView<StorageFile>> PickMultipleFilesAsync();
        IAsyncOperation<StorageFile> PickSingleFileAsync();

        string CommitButtonText { get; [param: In] set; }

        IVector<string> FileTypeFilter { get; }

        string SettingsIdentifier { get; [param: In] set; }

        PickerLocationId SuggestedStartLocation { get; [param: In] set; }

        PickerViewMode ViewMode { get; [param: In] set; }
    }
}

