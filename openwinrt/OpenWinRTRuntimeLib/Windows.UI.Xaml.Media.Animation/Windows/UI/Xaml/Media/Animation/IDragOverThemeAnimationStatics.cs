namespace Windows.UI.Xaml.Media.Animation
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [WebHostHidden, Guid(0x146ffe57, 0x3c9d, 0x41d9, 0xa5, 0xff, 0x8d, 0x72, 0x39, 0x51, 0x68, 0x10), ExclusiveTo(typeof(DragOverThemeAnimation)), Version(0x6020000)]
    internal interface IDragOverThemeAnimationStatics
    {
        DependencyProperty DirectionProperty { get; }

        DependencyProperty TargetNameProperty { get; }

        DependencyProperty ToOffsetProperty { get; }
    }
}

