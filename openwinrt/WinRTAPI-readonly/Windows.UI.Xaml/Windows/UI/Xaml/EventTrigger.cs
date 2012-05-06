namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Markup;

    [MarshalingBehavior(MarshalingType.FreeThreaded), WebHostHidden, Threading(ThreadingModel.Both), Activatable(0x6020000), Version(0x6020000), ContentProperty(Name="Actions")]
    public sealed class EventTrigger : TriggerBase, IEventTrigger
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public EventTrigger();

        public TriggerActionCollection Actions { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.RoutedEvent RoutedEvent { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public TriggerActionCollection Windows.UI.Xaml.IEventTrigger.Actions { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.RoutedEvent Windows.UI.Xaml.IEventTrigger.RoutedEvent { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

