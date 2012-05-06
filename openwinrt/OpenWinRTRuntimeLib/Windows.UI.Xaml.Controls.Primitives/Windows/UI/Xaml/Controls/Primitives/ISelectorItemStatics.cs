namespace Windows.UI.Xaml.Controls.Primitives
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Version(0x6020000), ExclusiveTo(typeof(SelectorItem)), Guid(0x2a353ab8, 0xcbe9, 0x4303, 0x92, 0xe7, 200, 0x90, 110, 0x21, 0x83, 0x92), WebHostHidden]
    internal interface ISelectorItemStatics
    {
        DependencyProperty IsSelectedProperty { get; }
    }
}

