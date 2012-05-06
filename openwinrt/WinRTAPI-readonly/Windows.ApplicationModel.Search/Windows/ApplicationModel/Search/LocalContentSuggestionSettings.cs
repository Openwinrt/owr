namespace Windows.ApplicationModel.Search
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Activatable(0x6020000)]
    public sealed class LocalContentSuggestionSettings : ILocalContentSuggestionSettings
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public LocalContentSuggestionSettings();

        public string AqsFilter { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Enabled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IVector<StorageFolder> Locations { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVector<string> PropertiesToMatch { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.ApplicationModel.Search.ILocalContentSuggestionSettings.AqsFilter { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.ApplicationModel.Search.ILocalContentSuggestionSettings.Enabled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public IVector<StorageFolder> Windows.ApplicationModel.Search.ILocalContentSuggestionSettings.Locations { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVector<string> Windows.ApplicationModel.Search.ILocalContentSuggestionSettings.PropertiesToMatch { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

