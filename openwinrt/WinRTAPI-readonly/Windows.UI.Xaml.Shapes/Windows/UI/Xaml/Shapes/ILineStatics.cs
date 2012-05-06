namespace Windows.UI.Xaml.Shapes
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [ExclusiveTo(typeof(Line)), Version(0x6020000), Guid(0x267c123d, 0x6ea4, 0x4c50, 0x8b, 0x1d, 80, 0x20, 0x7a, 0xff, 30, 0x8a), WebHostHidden]
    internal interface ILineStatics
    {
        DependencyProperty X1Property { get; }

        DependencyProperty X2Property { get; }

        DependencyProperty Y1Property { get; }

        DependencyProperty Y2Property { get; }
    }
}

