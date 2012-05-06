namespace Windows.UI.Core
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.System;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x79b9d5f2, 0x879e, 0x4b89, 0xb7, 0x98, 0x79, 0xe4, 0x75, 0x98, 3, 12), WebHostHidden]
    public interface ICoreWindow
    {
        event TypedEventHandler<CoreWindow, WindowActivatedEventArgs> Activated;

        event TypedEventHandler<CoreWindow, AutomationProviderRequestedEventArgs> AutomationProviderRequested;

        event TypedEventHandler<CoreWindow, CharacterReceivedEventArgs> CharacterReceived;

        event TypedEventHandler<CoreWindow, CoreWindowEventArgs> Closed;

        event TypedEventHandler<CoreWindow, InputEnabledEventArgs> InputEnabled;

        event TypedEventHandler<CoreWindow, KeyEventArgs> KeyDown;

        event TypedEventHandler<CoreWindow, KeyEventArgs> KeyUp;

        event TypedEventHandler<CoreWindow, PointerEventArgs> PointerCaptureLost;

        event TypedEventHandler<CoreWindow, PointerEventArgs> PointerEntered;

        event TypedEventHandler<CoreWindow, PointerEventArgs> PointerExited;

        event TypedEventHandler<CoreWindow, PointerEventArgs> PointerMoved;

        event TypedEventHandler<CoreWindow, PointerEventArgs> PointerPressed;

        event TypedEventHandler<CoreWindow, PointerEventArgs> PointerReleased;

        event TypedEventHandler<CoreWindow, PointerEventArgs> PointerWheelChanged;

        event TypedEventHandler<CoreWindow, WindowSizeChangedEventArgs> SizeChanged;

        event TypedEventHandler<CoreWindow, TouchHitTestingEventArgs> TouchHitTesting;

        event TypedEventHandler<CoreWindow, VisibilityChangedEventArgs> VisibilityChanged;

        void Activate();
        void Close();
        CoreVirtualKeyStates GetAsyncKeyState([In] VirtualKey virtualKey);
        CoreVirtualKeyStates GetKeyState([In] VirtualKey virtualKey);
        void ReleasePointerCapture();
        void SetPointerCapture();

        object AutomationHostProvider { get; }

        Rect Bounds { get; }

        IPropertySet CustomProperties { get; }

        CoreDispatcher Dispatcher { get; }

        CoreWindowFlowDirection FlowDirection { get; [param: In] set; }

        bool IsInputEnabled { get; [param: In] set; }

        CoreCursor PointerCursor { get; [param: In] set; }

        Point PointerPosition { get; }

        bool Visible { get; }
    }
}

