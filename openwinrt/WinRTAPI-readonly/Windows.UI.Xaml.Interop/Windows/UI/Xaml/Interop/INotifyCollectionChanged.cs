namespace Windows.UI.Xaml.Interop
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Windows.Foundation.Metadata.Guid(0x28b167d5, 0x1a31, 0x465b, 0x9b, 0x25, 0xd5, 0xc3, 0xae, 0x68, 0x6c, 0x40), Version(0x6020000)]
    public interface INotifyCollectionChanged
    {
        event NotifyCollectionChangedEventHandler CollectionChanged;
    }
}

