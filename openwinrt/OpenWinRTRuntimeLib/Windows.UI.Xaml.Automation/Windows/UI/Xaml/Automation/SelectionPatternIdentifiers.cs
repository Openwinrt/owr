namespace Windows.UI.Xaml.Automation
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Threading(ThreadingModel.Both), Static(typeof(ISelectionPatternIdentifiersStatics), 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000), WebHostHidden]
    public sealed class SelectionPatternIdentifiers : ISelectionPatternIdentifiers
    {
        public static AutomationProperty CanSelectMultipleProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static AutomationProperty IsSelectionRequiredProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static AutomationProperty SelectionProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

