namespace Windows.UI.Xaml.Automation.Provider
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x8b62b7a0, 0x932c, 0x4490, 0x9a, 0x13, 2, 0xfd, 0xb3, 0x9a, 0x8f, 0x5b), WebHostHidden, Version(0x6020000)]
    public interface IGridProvider
    {
        IRawElementProviderSimple GetItem([In] int row, [In] int column);

        int ColumnCount { get; }

        int RowCount { get; }
    }
}

