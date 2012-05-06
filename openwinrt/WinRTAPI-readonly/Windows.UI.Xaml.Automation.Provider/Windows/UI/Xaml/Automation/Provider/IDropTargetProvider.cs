namespace Windows.UI.Xaml.Automation.Provider
{
    using System;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Guid(0x7a245bdd, 0xb458, 0x4fe0, 0x98, 200, 170, 200, 0x9d, 0xf5, 0x6d, 0x61), Version(0x6020000)]
    public interface IDropTargetProvider
    {
        string DropEffect { get; }

        string[] DropEffects { get; }
    }
}

