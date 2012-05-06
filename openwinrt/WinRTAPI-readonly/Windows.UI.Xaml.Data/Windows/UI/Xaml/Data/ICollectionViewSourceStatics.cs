namespace Windows.UI.Xaml.Data
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Version(0x6020000), ExclusiveTo(typeof(CollectionViewSource)), WebHostHidden, Guid(0x173a0710, 0x46af, 0x4c0c, 0x81, 0x8b, 0x21, 0xb6, 0xef, 0x81, 0xbf, 0x65)]
    internal interface ICollectionViewSourceStatics
    {
        DependencyProperty IsSourceGroupedProperty { get; }

        DependencyProperty ItemsPathProperty { get; }

        DependencyProperty SourceProperty { get; }

        DependencyProperty ViewProperty { get; }
    }
}

