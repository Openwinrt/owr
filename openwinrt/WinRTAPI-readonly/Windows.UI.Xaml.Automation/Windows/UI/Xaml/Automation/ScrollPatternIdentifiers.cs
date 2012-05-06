namespace Windows.UI.Xaml.Automation
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000), WebHostHidden, Threading(ThreadingModel.Both), Static(typeof(IScrollPatternIdentifiersStatics), 0x6020000)]
    public sealed class ScrollPatternIdentifiers : IScrollPatternIdentifiers
    {
        public static AutomationProperty HorizontallyScrollableProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static AutomationProperty HorizontalScrollPercentProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static AutomationProperty HorizontalViewSizeProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static double NoScroll { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static AutomationProperty VerticallyScrollableProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static AutomationProperty VerticalScrollPercentProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static AutomationProperty VerticalViewSizeProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

