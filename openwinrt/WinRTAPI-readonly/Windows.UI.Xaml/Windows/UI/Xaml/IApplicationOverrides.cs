namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.ApplicationModel.Activation;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x25f99ff7, 0x9347, 0x459a, 0x9f, 0xac, 0xb2, 0xd0, 0xe1, 0x1c, 0x1a, 15), ExclusiveTo(typeof(Application)), WebHostHidden, Version(0x6020000)]
    internal interface IApplicationOverrides
    {
        void OnActivated([In] IActivatedEventArgs args);
        void OnCachedFileUpdaterActivated([In] CachedFileUpdaterActivatedEventArgs args);
        void OnFileActivated([In] FileActivatedEventArgs args);
        void OnFileOpenPickerActivated([In] FileOpenPickerActivatedEventArgs args);
        void OnFileSavePickerActivated([In] FileSavePickerActivatedEventArgs args);
        void OnLaunched([In] LaunchActivatedEventArgs args);
        void OnSearchActivated([In] SearchActivatedEventArgs args);
        void OnShareTargetActivated([In] ShareTargetActivatedEventArgs args);
    }
}

