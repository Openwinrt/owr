namespace Windows.Storage.Pickers
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Activatable(0x6020000), Version(0x6020000)]
    public sealed class FolderPicker : IFolderPicker
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public FolderPicker();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperation<StorageFolder> PickSingleFolderAsync();

        public string CommitButtonText { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IVector<string> FileTypeFilter { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string SettingsIdentifier { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public PickerLocationId SuggestedStartLocation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public PickerViewMode ViewMode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.Storage.Pickers.IFolderPicker.CommitButtonText { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IVector<string> Windows.Storage.Pickers.IFolderPicker.FileTypeFilter { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Storage.Pickers.IFolderPicker.SettingsIdentifier { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public PickerLocationId Windows.Storage.Pickers.IFolderPicker.SuggestedStartLocation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public PickerViewMode Windows.Storage.Pickers.IFolderPicker.ViewMode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

