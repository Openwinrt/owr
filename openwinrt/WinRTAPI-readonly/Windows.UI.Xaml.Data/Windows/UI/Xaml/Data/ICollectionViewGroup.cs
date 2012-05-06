namespace Windows.UI.Xaml.Data
{
    using System;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Guid(0x7e01b9d8, 0xd7b5, 0x48b6, 0xb3, 0x1c, 0x5b, 0xb5, 0xbd, 0xf5, 240, 0x9b), Version(0x6020000)]
    public interface ICollectionViewGroup
    {
        object Group { get; }

        IObservableVector<object> GroupItems { get; }
    }
}

