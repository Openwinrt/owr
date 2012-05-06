namespace Windows.UI.Xaml.Media
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [ExclusiveTo(typeof(PlaneProjection)), Version(0x6020000), Guid(0xad919c67, 0x3bdc, 0x4855, 0x89, 0x69, 0xd1, 0xf9, 0xa3, 0xad, 0xc2, 0x7d), WebHostHidden]
    internal interface IPlaneProjectionStatics
    {
        DependencyProperty CenterOfRotationXProperty { get; }

        DependencyProperty CenterOfRotationYProperty { get; }

        DependencyProperty CenterOfRotationZProperty { get; }

        DependencyProperty GlobalOffsetXProperty { get; }

        DependencyProperty GlobalOffsetYProperty { get; }

        DependencyProperty GlobalOffsetZProperty { get; }

        DependencyProperty LocalOffsetXProperty { get; }

        DependencyProperty LocalOffsetYProperty { get; }

        DependencyProperty LocalOffsetZProperty { get; }

        DependencyProperty ProjectionMatrixProperty { get; }

        DependencyProperty RotationXProperty { get; }

        DependencyProperty RotationYProperty { get; }

        DependencyProperty RotationZProperty { get; }
    }
}

