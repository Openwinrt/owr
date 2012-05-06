namespace Windows.UI.Xaml.Controls.Primitives
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [ExclusiveTo(typeof(RepeatButton)), Version(0x6020000), WebHostHidden, Guid(0x3914ac4e, 0xf462, 0x4f73, 0x81, 0x97, 0xe8, 0x84, 0x66, 0x39, 0xc6, 130)]
    internal interface IRepeatButtonStatics
    {
        DependencyProperty DelayProperty { get; }

        DependencyProperty IntervalProperty { get; }
    }
}

