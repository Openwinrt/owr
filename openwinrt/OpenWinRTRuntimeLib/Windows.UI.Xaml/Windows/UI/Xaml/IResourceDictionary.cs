namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), WebHostHidden, Windows.Foundation.Metadata.Guid(0xc1ea4f24, 0xd6de, 0x4191, 0x8e, 0x3a, 0xf4, 0x86, 1, 0xf7, 0x48, 0x9c), ExclusiveTo(typeof(ResourceDictionary))]
    internal interface IResourceDictionary
    {
        IVector<ResourceDictionary> MergedDictionaries { get; }

        Uri Source { get; [param: In] set; }

        IMap<object, object> ThemeDictionaries { get; }
    }
}

