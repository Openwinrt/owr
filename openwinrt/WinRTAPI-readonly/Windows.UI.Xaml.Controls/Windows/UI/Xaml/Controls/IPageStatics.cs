namespace Windows.UI.Xaml.Controls
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Guid(0x376dde71, 0xf725, 0x46dd, 0x8d, 0x80, 0xee, 0xea, 0xf7, 0xda, 0x74, 0xe5), WebHostHidden, ExclusiveTo(typeof(Page)), Version(0x6020000)]
    internal interface IPageStatics
    {
        DependencyProperty BottomAppBarProperty { get; }

        DependencyProperty FrameProperty { get; }

        DependencyProperty TopAppBarProperty { get; }
    }
}

