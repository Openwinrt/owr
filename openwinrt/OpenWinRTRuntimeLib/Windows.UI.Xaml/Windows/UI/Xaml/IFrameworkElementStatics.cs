namespace Windows.UI.Xaml
{
    using Windows.Foundation.Metadata;

    [Guid(0x48383032, 0xfbeb, 0x4f8a, 0xae, 210, 0xee, 0x21, 0xfb, 0x27, 0xa5, 0x7b), Version(0x6020000), ExclusiveTo(typeof(FrameworkElement)), WebHostHidden]
    internal interface IFrameworkElementStatics
    {
        DependencyProperty ActualHeightProperty { get; }

        DependencyProperty ActualWidthProperty { get; }

        DependencyProperty DataContextProperty { get; }

        DependencyProperty FlowDirectionProperty { get; }

        DependencyProperty HeightProperty { get; }

        DependencyProperty HorizontalAlignmentProperty { get; }

        DependencyProperty LanguageProperty { get; }

        DependencyProperty MarginProperty { get; }

        DependencyProperty MaxHeightProperty { get; }

        DependencyProperty MaxWidthProperty { get; }

        DependencyProperty MinHeightProperty { get; }

        DependencyProperty MinWidthProperty { get; }

        DependencyProperty NameProperty { get; }

        DependencyProperty StyleProperty { get; }

        DependencyProperty TagProperty { get; }

        DependencyProperty VerticalAlignmentProperty { get; }

        DependencyProperty WidthProperty { get; }
    }
}

