namespace Windows.UI.Xaml.Controls
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Guid(0x8ef17ef2, 0x9898, 0x4666, 0xb2, 0x85, 0x3e, 0xd3, 0x8a, 7, 0x91, 14), ExclusiveTo(typeof(SemanticZoom)), Version(0x6020000), WebHostHidden]
    internal interface ISemanticZoomStatics
    {
        DependencyProperty CanChangeViewsProperty { get; }

        DependencyProperty IsZoomedInViewActiveProperty { get; }

        DependencyProperty ZoomedInViewProperty { get; }

        DependencyProperty ZoomedOutViewProperty { get; }
    }
}

