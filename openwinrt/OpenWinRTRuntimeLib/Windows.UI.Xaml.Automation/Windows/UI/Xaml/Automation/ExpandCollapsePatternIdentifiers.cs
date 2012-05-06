namespace Windows.UI.Xaml.Automation
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Threading(ThreadingModel.Both), MarshalingBehavior(MarshalingType.FreeThreaded), Static(typeof(IExpandCollapsePatternIdentifiersStatics), 0x6020000), WebHostHidden, Version(0x6020000)]
    public sealed class ExpandCollapsePatternIdentifiers : IExpandCollapsePatternIdentifiers
    {
        public static AutomationProperty ExpandCollapseStateProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

