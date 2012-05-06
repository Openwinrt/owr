namespace Windows.UI.Xaml.Automation
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), WebHostHidden, Static(typeof(IWindowPatternIdentifiersStatics), 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both)]
    public sealed class WindowPatternIdentifiers : IWindowPatternIdentifiers
    {
        public static AutomationProperty CanMaximizeProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static AutomationProperty CanMinimizeProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static AutomationProperty IsModalProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static AutomationProperty IsTopmostProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static AutomationProperty WindowInteractionStateProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static AutomationProperty WindowVisualStateProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

