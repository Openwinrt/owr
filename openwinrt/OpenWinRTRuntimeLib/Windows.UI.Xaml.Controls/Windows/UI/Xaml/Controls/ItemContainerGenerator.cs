namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls.Primitives;

    [Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), WebHostHidden, Threading(ThreadingModel.Both)]
    public sealed class ItemContainerGenerator : Windows.UI.Xaml.Controls.IItemContainerGenerator, IRecyclingItemContainerGenerator, Windows.UI.Xaml.Controls.Primitives.IItemContainerGenerator
    {
        public event ItemsChangedEventHandler ItemsChanged;

        public event ItemsChangedEventHandler Windows.UI.Xaml.Controls.IItemContainerGenerator.ItemsChanged;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public DependencyObject ContainerFromIndex([In] int index);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public DependencyObject ContainerFromItem([In] object item);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public DependencyObject GenerateNext(out bool isNewlyRealized);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public GeneratorPosition GeneratorPositionFromIndex([In] int itemIndex);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ItemContainerGenerator GetItemContainerGeneratorForPanel([In] Panel panel);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public int IndexFromContainer([In] DependencyObject container);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public int IndexFromGeneratorPosition([In] GeneratorPosition position);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public object ItemFromContainer([In] DependencyObject container);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void PrepareItemContainer([In] DependencyObject container);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Recycle([In] GeneratorPosition position, [In] int count);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Remove([In] GeneratorPosition position, [In] int count);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void RemoveAll();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void StartAt([In] GeneratorPosition position, [In] GeneratorDirection direction, [In] bool allowStartAtRealizedItem);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Stop();
    }
}

