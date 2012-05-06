namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Automation;
    using Windows.UI.Xaml.Automation.Provider;

    [Threading(ThreadingModel.Both), WebHostHidden, Version(0x6020000), Static(typeof(IAutomationPeerStatics), 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Composable(typeof(IAutomationPeerFactory), CompositionType.Protected, 0x6020000)]
    public class AutomationPeer : DependencyObject, IAutomationPeer, IAutomationPeerOverrides, IAutomationPeerProtected
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected AutomationPeer();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public string GetAcceleratorKey();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual string GetAcceleratorKeyCore();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public string GetAccessKey();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual string GetAccessKeyCore();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public AutomationControlType GetAutomationControlType();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual AutomationControlType GetAutomationControlTypeCore();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public string GetAutomationId();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual string GetAutomationIdCore();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Rect GetBoundingRectangle();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual Rect GetBoundingRectangleCore();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IVector<AutomationPeer> GetChildren();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual IVector<AutomationPeer> GetChildrenCore();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public string GetClassName();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual string GetClassNameCore();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Point GetClickablePoint();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual Point GetClickablePointCore();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public string GetHelpText();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual string GetHelpTextCore();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public string GetItemStatus();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual string GetItemStatusCore();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public string GetItemType();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual string GetItemTypeCore();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public AutomationPeer GetLabeledBy();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual AutomationPeer GetLabeledByCore();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public string GetLocalizedControlType();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual string GetLocalizedControlTypeCore();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public string GetName();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual string GetNameCore();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public AutomationOrientation GetOrientation();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual AutomationOrientation GetOrientationCore();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public AutomationPeer GetParent();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public object GetPattern([In] PatternInterface patternInterface);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual object GetPatternCore([In] PatternInterface patternInterface);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected AutomationPeer GetPeerFromPoint([In] Point point);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool HasKeyboardFocus();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual bool HasKeyboardFocusCore();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void InvalidatePeer();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool IsContentElement();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual bool IsContentElementCore();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool IsControlElement();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual bool IsControlElementCore();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool IsEnabled();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual bool IsEnabledCore();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool IsKeyboardFocusable();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual bool IsKeyboardFocusableCore();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool IsOffscreen();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual bool IsOffscreenCore();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool IsPassword();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual bool IsPasswordCore();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool IsRequiredForForm();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual bool IsRequiredForFormCore();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool ListenerExists([In] AutomationEvents eventId);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected AutomationPeer PeerFromProvider([In] IRawElementProviderSimple provider);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected IRawElementProviderSimple ProviderFromPeer([In] AutomationPeer peer);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void RaiseAutomationEvent([In] AutomationEvents eventId);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void RaisePropertyChangedEvent([In] AutomationProperty property, [In] object oldValue, [In] object newValue);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SetFocus();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual void SetFocusCore();

        public AutomationPeer EventsSource { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public AutomationPeer Windows.UI.Xaml.Automation.Peers.IAutomationPeer.EventsSource { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

