namespace Windows.UI.Xaml.Media
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [ExclusiveTo(typeof(PathFigure)), WebHostHidden, Version(0x6020000), Guid(0xb60591d9, 0x2395, 0x4317, 0x95, 0x52, 0x3a, 0x58, 0x52, 0x6f, 140, 0x7b)]
    internal interface IPathFigureStatics
    {
        DependencyProperty IsClosedProperty { get; }

        DependencyProperty IsFilledProperty { get; }

        DependencyProperty SegmentsProperty { get; }

        DependencyProperty StartPointProperty { get; }
    }
}

