namespace Windows.UI.Xaml.Automation
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Threading(ThreadingModel.Both), WebHostHidden, Version(0x6020000), Static(typeof(ITogglePatternIdentifiersStatics), 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class TogglePatternIdentifiers : ITogglePatternIdentifiers
    {
        public static AutomationProperty ToggleStateProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

