namespace Windows.UI.Xaml.Automation
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Threading(ThreadingModel.Both), Version(0x6020000), Static(typeof(ITablePatternIdentifiersStatics), 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class TablePatternIdentifiers : ITablePatternIdentifiers
    {
        public static AutomationProperty ColumnHeadersProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static AutomationProperty RowHeadersProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static AutomationProperty RowOrColumnMajorProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

