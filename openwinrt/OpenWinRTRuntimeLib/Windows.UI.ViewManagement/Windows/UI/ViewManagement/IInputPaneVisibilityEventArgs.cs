namespace Windows.UI.ViewManagement
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0xd243e016, 0xd907, 0x4fcc, 0xbb, 0x8d, 0xf7, 0x7b, 170, 80, 40, 0xf1), ExclusiveTo(typeof(InputPaneVisibilityEventArgs))]
    internal interface IInputPaneVisibilityEventArgs
    {
        bool EnsuredFocusedElementInView { get; [param: In] set; }

        Rect OccludedRect { get; }
    }
}

