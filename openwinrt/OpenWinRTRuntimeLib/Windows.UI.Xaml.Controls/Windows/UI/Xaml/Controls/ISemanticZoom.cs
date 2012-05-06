namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Windows.Foundation.Metadata.Guid(0x19fff21, 0xece6, 0x4fbc, 0xbf, 0x40, 0x89, 0x38, 0xd4, 0x81, 0x3e, 0x27), Version(0x6020000), ExclusiveTo(typeof(SemanticZoom))]
    internal interface ISemanticZoom
    {
        event SemanticZoomViewChangedEventHandler ViewChangeCompleted;

        event SemanticZoomViewChangedEventHandler ViewChangeStarted;

        void ToggleActiveView();

        bool CanChangeViews { get; [param: In] set; }

        bool IsZoomedInViewActive { get; [param: In] set; }

        ISemanticZoomInformation ZoomedInView { get; [param: In] set; }

        ISemanticZoomInformation ZoomedOutView { get; [param: In] set; }
    }
}

