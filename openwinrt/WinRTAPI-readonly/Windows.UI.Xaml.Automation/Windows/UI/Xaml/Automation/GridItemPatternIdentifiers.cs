namespace Windows.UI.Xaml.Automation
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Static(typeof(IGridItemPatternIdentifiersStatics), 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), WebHostHidden, Threading(ThreadingModel.Both), Version(0x6020000)]
    public sealed class GridItemPatternIdentifiers : IGridItemPatternIdentifiers
    {
        public static AutomationProperty ColumnProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static AutomationProperty ColumnSpanProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static AutomationProperty ContainingGridProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static AutomationProperty RowProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static AutomationProperty RowSpanProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

