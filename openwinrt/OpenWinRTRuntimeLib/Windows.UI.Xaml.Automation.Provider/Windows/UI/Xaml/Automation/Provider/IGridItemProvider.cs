namespace Windows.UI.Xaml.Automation.Provider
{
    using System;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Guid(0xfff3683c, 0x7407, 0x45bb, 0xa9, 0x36, 0xdf, 0x3e, 0xd6, 0xd3, 0x83, 0x7d), Version(0x6020000)]
    public interface IGridItemProvider
    {
        int Column { get; }

        int ColumnSpan { get; }

        IRawElementProviderSimple ContainingGrid { get; }

        int Row { get; }

        int RowSpan { get; }
    }
}

