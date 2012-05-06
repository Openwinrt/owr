namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x47dfc068, 0xb569, 0x4b19, 0x84, 0x2d, 0x8e, 0x6c, 0xf9, 9, 0x89, 0xaf), ExclusiveTo(typeof(SemanticZoomViewChangedEventArgs)), WebHostHidden]
    internal interface ISemanticZoomViewChangedEventArgs
    {
        SemanticZoomLocation DestinationItem { get; [param: In] set; }

        bool IsSourceZoomedInView { get; [param: In] set; }

        SemanticZoomLocation SourceItem { get; [param: In] set; }
    }
}

