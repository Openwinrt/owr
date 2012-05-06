namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(ResourceDictionary)), Version(0x6020000), WebHostHidden, Windows.Foundation.Metadata.Guid(0xea3639b5, 0x31b7, 0x4271, 0x92, 0xc9, 0x7c, 0x95, 0x84, 0xa9, 0x1c, 0x22)]
    internal interface IResourceDictionaryFactory
    {
        ResourceDictionary CreateInstance([In] object outer, out object inner);
    }
}

