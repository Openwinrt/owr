namespace Windows.UI.Xaml.Data
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [ExclusiveTo(typeof(CollectionViewSource)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0xa66a1146, 0xd2fb, 0x4ead, 190, 0x9f, 0x35, 120, 0xa4, 0x66, 220, 0xfe), WebHostHidden]
    internal interface ICollectionViewSource
    {
        bool IsSourceGrouped { get; [param: In] set; }

        PropertyPath ItemsPath { get; [param: In] set; }

        object Source { get; [param: In] set; }

        ICollectionView View { get; }
    }
}

