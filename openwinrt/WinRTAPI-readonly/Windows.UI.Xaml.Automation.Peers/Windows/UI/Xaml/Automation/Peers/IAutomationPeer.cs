namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Automation;

    [ExclusiveTo(typeof(AutomationPeer)), WebHostHidden, Windows.Foundation.Metadata.Guid(0x35aac87a, 0x62ee, 0x4d3e, 0xa2, 0x4c, 0x2b, 200, 0x43, 0x2d, 0x68, 0xb7), Version(0x6020000)]
    internal interface IAutomationPeer
    {
        string GetAcceleratorKey();
        string GetAccessKey();
        AutomationControlType GetAutomationControlType();
        string GetAutomationId();
        Rect GetBoundingRectangle();
        IVector<AutomationPeer> GetChildren();
        string GetClassName();
        Point GetClickablePoint();
        string GetHelpText();
        string GetItemStatus();
        string GetItemType();
        AutomationPeer GetLabeledBy();
        string GetLocalizedControlType();
        string GetName();
        AutomationOrientation GetOrientation();
        AutomationPeer GetParent();
        object GetPattern([In] PatternInterface patternInterface);
        bool HasKeyboardFocus();
        void InvalidatePeer();
        bool IsContentElement();
        bool IsControlElement();
        bool IsEnabled();
        bool IsKeyboardFocusable();
        bool IsOffscreen();
        bool IsPassword();
        bool IsRequiredForForm();
        void RaiseAutomationEvent([In] AutomationEvents eventId);
        void RaisePropertyChangedEvent([In] AutomationProperty property, [In] object oldValue, [In] object newValue);
        void SetFocus();

        AutomationPeer EventsSource { get; [param: In] set; }
    }
}

