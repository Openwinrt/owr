namespace Windows.UI.Xaml.Controls.Primitives
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), WebHostHidden, Windows.Foundation.Metadata.Guid(0x911383b0, 0xb26b, 0x4efc, 0x9f, 120, 0x6a, 0x4a, 0x26, 0x2f, 0x7f, 0x26)]
    public interface IRecyclingItemContainerGenerator : IItemContainerGenerator
    {
        void Recycle([In] GeneratorPosition position, [In] int count);
    }
}

