namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Windows.Foundation.Metadata.Guid(0xa76a3b63, 0x229b, 0x4dc5, 170, 0x11, 0x9d, 0x92, 0x2f, 0xbf, 0x8a, 0x98), Version(0x6020000)]
    public interface ISemanticZoomInformation
    {
        void CompleteViewChange();
        void CompleteViewChangeFrom([In] SemanticZoomLocation source, [In] SemanticZoomLocation destination);
        void CompleteViewChangeTo([In] SemanticZoomLocation source, [In] SemanticZoomLocation destination);
        void InitializeViewChange();
        void MakeVisible([In] SemanticZoomLocation item);
        void StartViewChangeFrom([In] SemanticZoomLocation source, [In] SemanticZoomLocation destination);
        void StartViewChangeTo([In] SemanticZoomLocation source, [In] SemanticZoomLocation destination);

        bool IsActiveView { get; [param: In] set; }

        bool IsZoomedInView { get; [param: In] set; }

        SemanticZoom SemanticZoomOwner { get; [param: In] set; }
    }
}

