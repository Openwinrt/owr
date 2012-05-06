namespace Windows.UI.Xaml.Controls
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [ExclusiveTo(typeof(StackPanel)), Version(0x6020000), Guid(0xf0d0cd93, 0x4dbc, 0x48a7, 0x99, 20, 0x95, 0x49, 0x24, 0x65, 0x77, 0x71), WebHostHidden]
    internal interface IStackPanelStatics
    {
        DependencyProperty AreScrollSnapPointsRegularProperty { get; }

        DependencyProperty OrientationProperty { get; }
    }
}

