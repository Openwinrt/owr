namespace Windows.UI.Xaml.Automation
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Threading(ThreadingModel.Both), Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Static(typeof(IGridPatternIdentifiersStatics), 0x6020000), WebHostHidden]
    public sealed class GridPatternIdentifiers : IGridPatternIdentifiers
    {
        public static AutomationProperty ColumnCountProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static AutomationProperty RowCountProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

