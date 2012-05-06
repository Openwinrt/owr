namespace Windows.Storage.Pickers
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.Storage;

    [ExclusiveTo(typeof(FileSavePicker)), Windows.Foundation.Metadata.Guid(0x3286ffcb, 0x617f, 0x4cc5, 0xaf, 0x6a, 0xb3, 0xfd, 0xf2, 0x9a, 0xd1, 0x45), Version(0x6020000)]
    internal interface IFileSavePicker
    {
        IAsyncOperation<StorageFile> PickSaveFileAsync();

        string CommitButtonText { get; [param: In] set; }

        string DefaultFileExtension { get; [param: In] set; }

        IMap<string, IVector<string>> FileTypeChoices { get; }

        string SettingsIdentifier { get; [param: In] set; }

        string SuggestedFileName { get; [param: In] set; }

        StorageFile SuggestedSaveFile { get; [param: In] set; }

        PickerLocationId SuggestedStartLocation { get; [param: In] set; }
    }
}

