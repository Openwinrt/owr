namespace Windows.UI.Xaml.Automation
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both), WebHostHidden, Version(0x6020000), Static(typeof(ISelectionItemPatternIdentifiersStatics), 0x6020000)]
    public sealed class SelectionItemPatternIdentifiers : ISelectionItemPatternIdentifiers
    {
        public static AutomationProperty IsSelectedProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static AutomationProperty SelectionContainerProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

