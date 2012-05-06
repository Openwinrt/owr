namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Windows.Foundation.Metadata.Guid(0xbea93e67, 0xdbee, 0x4f7b, 0xaf, 13, 0xa7, 0x9a, 0xae, 0x53, 0x33, 0xbf), ExclusiveTo(typeof(AutomationPeer)), Version(0x6020000)]
    internal interface IAutomationPeerOverrides
    {
        string GetAcceleratorKeyCore();
        string GetAccessKeyCore();
        AutomationControlType GetAutomationControlTypeCore();
        string GetAutomationIdCore();
        Rect GetBoundingRectangleCore();
        IVector<AutomationPeer> GetChildrenCore();
        string GetClassNameCore();
        Point GetClickablePointCore();
        string GetHelpTextCore();
        string GetItemStatusCore();
        string GetItemTypeCore();
        AutomationPeer GetLabeledByCore();
        string GetLocalizedControlTypeCore();
        string GetNameCore();
        AutomationOrientation GetOrientationCore();
        object GetPatternCore([In] PatternInterface patternInterface);
        bool HasKeyboardFocusCore();
        bool IsContentElementCore();
        bool IsControlElementCore();
        bool IsEnabledCore();
        bool IsKeyboardFocusableCore();
        bool IsOffscreenCore();
        bool IsPasswordCore();
        bool IsRequiredForFormCore();
        void SetFocusCore();
    }
}

