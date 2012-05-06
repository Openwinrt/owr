namespace Windows.UI.Core
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.System;

    [Static(typeof(ICoreWindowStatic), 0x6020000), WebHostHidden, Version(0x6020000)]
    public sealed class CoreWindow : ICoreWindow
    {
        public event TypedEventHandler<CoreWindow, WindowActivatedEventArgs> Activated;

        public event TypedEventHandler<CoreWindow, AutomationProviderRequestedEventArgs> AutomationProviderRequested;

        public event TypedEventHandler<CoreWindow, CharacterReceivedEventArgs> CharacterReceived;

        public event TypedEventHandler<CoreWindow, CoreWindowEventArgs> Closed;

        public event TypedEventHandler<CoreWindow, InputEnabledEventArgs> InputEnabled;

        public event TypedEventHandler<CoreWindow, KeyEventArgs> KeyDown;

        public event TypedEventHandler<CoreWindow, KeyEventArgs> KeyUp;

        public event TypedEventHandler<CoreWindow, PointerEventArgs> PointerCaptureLost;

        public event TypedEventHandler<CoreWindow, PointerEventArgs> PointerEntered;

        public event TypedEventHandler<CoreWindow, PointerEventArgs> PointerExited;

        public event TypedEventHandler<CoreWindow, PointerEventArgs> PointerMoved;

        public event TypedEventHandler<CoreWindow, PointerEventArgs> PointerPressed;

        public event TypedEventHandler<CoreWindow, PointerEventArgs> PointerReleased;

        public event TypedEventHandler<CoreWindow, PointerEventArgs> PointerWheelChanged;

        public event TypedEventHandler<CoreWindow, WindowSizeChangedEventArgs> SizeChanged;

        public event TypedEventHandler<CoreWindow, TouchHitTestingEventArgs> TouchHitTesting;

        public event TypedEventHandler<CoreWindow, VisibilityChangedEventArgs> VisibilityChanged;

        public event TypedEventHandler<CoreWindow, WindowActivatedEventArgs> Windows.UI.Core.ICoreWindow.Activated;

        public event TypedEventHandler<CoreWindow, AutomationProviderRequestedEventArgs> Windows.UI.Core.ICoreWindow.AutomationProviderRequested;

        public event TypedEventHandler<CoreWindow, CharacterReceivedEventArgs> Windows.UI.Core.ICoreWindow.CharacterReceived;

        public event TypedEventHandler<CoreWindow, CoreWindowEventArgs> Windows.UI.Core.ICoreWindow.Closed;

        public event TypedEventHandler<CoreWindow, InputEnabledEventArgs> Windows.UI.Core.ICoreWindow.InputEnabled;

        public event TypedEventHandler<CoreWindow, KeyEventArgs> Windows.UI.Core.ICoreWindow.KeyDown;

        public event TypedEventHandler<CoreWindow, KeyEventArgs> Windows.UI.Core.ICoreWindow.KeyUp;

        public event TypedEventHandler<CoreWindow, PointerEventArgs> Windows.UI.Core.ICoreWindow.PointerCaptureLost;

        public event TypedEventHandler<CoreWindow, PointerEventArgs> Windows.UI.Core.ICoreWindow.PointerEntered;

        public event TypedEventHandler<CoreWindow, PointerEventArgs> Windows.UI.Core.ICoreWindow.PointerExited;

        public event TypedEventHandler<CoreWindow, PointerEventArgs> Windows.UI.Core.ICoreWindow.PointerMoved;

        public event TypedEventHandler<CoreWindow, PointerEventArgs> Windows.UI.Core.ICoreWindow.PointerPressed;

        public event TypedEventHandler<CoreWindow, PointerEventArgs> Windows.UI.Core.ICoreWindow.PointerReleased;

        public event TypedEventHandler<CoreWindow, PointerEventArgs> Windows.UI.Core.ICoreWindow.PointerWheelChanged;

        public event TypedEventHandler<CoreWindow, WindowSizeChangedEventArgs> Windows.UI.Core.ICoreWindow.SizeChanged;

        public event TypedEventHandler<CoreWindow, TouchHitTestingEventArgs> Windows.UI.Core.ICoreWindow.TouchHitTesting;

        public event TypedEventHandler<CoreWindow, VisibilityChangedEventArgs> Windows.UI.Core.ICoreWindow.VisibilityChanged;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Activate();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Close();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public CoreVirtualKeyStates GetAsyncKeyState([In] VirtualKey virtualKey);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static CoreWindow GetForCurrentThread();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public CoreVirtualKeyStates GetKeyState([In] VirtualKey virtualKey);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void ReleasePointerCapture();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SetPointerCapture();

        public object AutomationHostProvider { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Rect Bounds { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static CoreWindow Current { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IPropertySet CustomProperties { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public CoreDispatcher Dispatcher { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public CoreWindowFlowDirection FlowDirection { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool IsInputEnabled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public CoreCursor PointerCursor { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Point PointerPosition { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Visible { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public object Windows.UI.Core.ICoreWindow.AutomationHostProvider { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Rect Windows.UI.Core.ICoreWindow.Bounds { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IPropertySet Windows.UI.Core.ICoreWindow.CustomProperties { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public CoreDispatcher Windows.UI.Core.ICoreWindow.Dispatcher { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public CoreWindowFlowDirection Windows.UI.Core.ICoreWindow.FlowDirection { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.UI.Core.ICoreWindow.IsInputEnabled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public CoreCursor Windows.UI.Core.ICoreWindow.PointerCursor { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Point Windows.UI.Core.ICoreWindow.PointerPosition { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Core.ICoreWindow.Visible { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

