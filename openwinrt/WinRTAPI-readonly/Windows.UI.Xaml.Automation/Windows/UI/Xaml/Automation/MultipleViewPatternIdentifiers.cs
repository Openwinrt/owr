namespace Windows.UI.Xaml.Automation
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Threading(ThreadingModel.Both), Version(0x6020000), Static(typeof(IMultipleViewPatternIdentifiersStatics), 0x6020000), WebHostHidden, MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class MultipleViewPatternIdentifiers : IMultipleViewPatternIdentifiers
    {
        public static AutomationProperty CurrentViewProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static AutomationProperty SupportedViewsProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

