namespace Windows.UI.Xaml.Controls.Primitives
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls;

    [Windows.Foundation.Metadata.Guid(0x2f43cd15, 0x4303, 0x462a, 0x9f, 0x7e, 0xb9, 0xe3, 0x2e, 0xa4, 0xbb, 0xc0), Version(0x6020000), WebHostHidden]
    public interface IItemContainerGenerator
    {
        DependencyObject GenerateNext(out bool isNewlyRealized);
        GeneratorPosition GeneratorPositionFromIndex([In] int itemIndex);
        ItemContainerGenerator GetItemContainerGeneratorForPanel([In] Panel panel);
        int IndexFromGeneratorPosition([In] GeneratorPosition position);
        void PrepareItemContainer([In] DependencyObject container);
        void Remove([In] GeneratorPosition position, [In] int count);
        void RemoveAll();
        void StartAt([In] GeneratorPosition position, [In] GeneratorDirection direction, [In] bool allowStartAtRealizedItem);
        void Stop();
    }
}

