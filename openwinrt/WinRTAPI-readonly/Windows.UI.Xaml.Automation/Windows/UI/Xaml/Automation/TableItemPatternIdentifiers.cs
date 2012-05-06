namespace Windows.UI.Xaml.Automation
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Static(typeof(ITableItemPatternIdentifiersStatics), 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both), WebHostHidden, Version(0x6020000)]
    public sealed class TableItemPatternIdentifiers : ITableItemPatternIdentifiers
    {
        public static AutomationProperty ColumnHeaderItemsProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static AutomationProperty RowHeaderItemsProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

