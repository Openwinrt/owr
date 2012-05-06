namespace Windows.UI.Xaml.Controls
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [WebHostHidden, Guid(0xf23d6b5d, 0x8330, 0x47a6, 160, 70, 0x25, 0xf5, 9, 0xb2, 0x52, 50), Version(0x6020000), ExclusiveTo(typeof(Panel))]
    internal interface IPanelStatics
    {
        DependencyProperty BackgroundProperty { get; }

        DependencyProperty ChildrenTransitionsProperty { get; }

        DependencyProperty IsItemsHostProperty { get; }
    }
}

