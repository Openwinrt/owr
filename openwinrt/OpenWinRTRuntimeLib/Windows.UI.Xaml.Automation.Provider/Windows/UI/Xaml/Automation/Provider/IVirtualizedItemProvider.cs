namespace Windows.UI.Xaml.Automation.Provider
{
    using System;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Version(0x6020000), Guid(0x17d4a04b, 0xd658, 0x48e0, 0xa5, 0x74, 90, 0x51, 0x6c, 0x58, 0xdf, 0xa7)]
    public interface IVirtualizedItemProvider
    {
        void Realize();
    }
}

