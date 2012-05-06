namespace Windows.UI.Xaml.Shapes
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [WebHostHidden, Guid(0x1d7b4c55, 0x9df3, 0x48dc, 0x91, 0x94, 0x9d, 0x30, 0x6f, 170, 0x60, 0x89), Version(0x6020000), ExclusiveTo(typeof(Shape))]
    internal interface IShapeStatics
    {
        DependencyProperty FillProperty { get; }

        DependencyProperty StretchProperty { get; }

        DependencyProperty StrokeDashArrayProperty { get; }

        DependencyProperty StrokeDashCapProperty { get; }

        DependencyProperty StrokeDashOffsetProperty { get; }

        DependencyProperty StrokeEndLineCapProperty { get; }

        DependencyProperty StrokeLineJoinProperty { get; }

        DependencyProperty StrokeMiterLimitProperty { get; }

        DependencyProperty StrokeProperty { get; }

        DependencyProperty StrokeStartLineCapProperty { get; }

        DependencyProperty StrokeThicknessProperty { get; }
    }
}

