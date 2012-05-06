namespace Windows.UI.Xaml.Automation.Provider
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0x9a3ec090, 0x5d2c, 0x4e42, 0x9e, 230, 0x9d, 0x58, 0xdb, 0x10, 11, 0x55), WebHostHidden]
    public interface IScrollItemProvider
    {
        void ScrollIntoView();
    }
}

