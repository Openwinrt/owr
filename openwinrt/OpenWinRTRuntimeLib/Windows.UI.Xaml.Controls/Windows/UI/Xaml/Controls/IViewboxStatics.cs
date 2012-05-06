namespace Windows.UI.Xaml.Controls
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [ExclusiveTo(typeof(Viewbox)), Version(0x6020000), Guid(0x5cd1e72d, 0xe8d3, 0x4865, 0x8f, 8, 0xb6, 0xb2, 0xd6, 0x89, 0xad, 0xf1), WebHostHidden]
    internal interface IViewboxStatics
    {
        DependencyProperty StretchDirectionProperty { get; }

        DependencyProperty StretchProperty { get; }
    }
}

