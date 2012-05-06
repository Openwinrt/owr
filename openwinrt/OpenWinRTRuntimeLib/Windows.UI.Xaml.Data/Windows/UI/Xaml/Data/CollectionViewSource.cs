namespace Windows.UI.Xaml.Data
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Static(typeof(ICollectionViewSourceStatics), 0x6020000), Activatable(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both), WebHostHidden, Version(0x6020000)]
    public sealed class CollectionViewSource : DependencyObject, ICollectionViewSource
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public CollectionViewSource();

        public bool IsSourceGrouped { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty IsSourceGroupedProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public PropertyPath ItemsPath { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty ItemsPathProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public object Source { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty SourceProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ICollectionView View { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static DependencyProperty ViewProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Xaml.Data.ICollectionViewSource.IsSourceGrouped { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public PropertyPath Windows.UI.Xaml.Data.ICollectionViewSource.ItemsPath { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public object Windows.UI.Xaml.Data.ICollectionViewSource.Source { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public ICollectionView Windows.UI.Xaml.Data.ICollectionViewSource.View { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

