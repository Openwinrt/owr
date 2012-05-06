namespace Windows.UI.Xaml.Data
{
    using Windows.Foundation.Metadata;

    [Guid(0x34d4aaf4, 0x8e72, 0x4950, 0x91, 0x92, 0xec, 0xd0, 0x7d, 0x39, 0x9d, 10), WebHostHidden, Version(0x6020000)]
    public interface ICollectionViewFactory
    {
        ICollectionView CreateView();
    }
}

