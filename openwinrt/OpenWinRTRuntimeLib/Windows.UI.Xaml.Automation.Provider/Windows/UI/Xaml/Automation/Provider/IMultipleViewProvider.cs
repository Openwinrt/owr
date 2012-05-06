namespace Windows.UI.Xaml.Automation.Provider
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xd014e196, 0xe50, 0x4843, 0xa5, 210, 0xc2, 40, 0x97, 200, 0x84, 90), Version(0x6020000), WebHostHidden]
    public interface IMultipleViewProvider
    {
        int[] GetSupportedViews();
        string GetViewName([In] int viewId);
        void SetCurrentView([In] int viewId);

        int CurrentView { get; }
    }
}

