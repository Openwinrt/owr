namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Core;

    [WebHostHidden, Version(0x6020000), Static(typeof(IWindowStatics), 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both)]
    public sealed class Window : IWindow
    {
        public event WindowActivatedEventHandler Activated;

        public event WindowClosedEventHandler Closed;

        public event WindowSizeChangedEventHandler SizeChanged;

        public event WindowVisibilityChangedEventHandler VisibilityChanged;

        public event WindowActivatedEventHandler Windows.UI.Xaml.IWindow.Activated;

        public event WindowClosedEventHandler Windows.UI.Xaml.IWindow.Closed;

        public event WindowSizeChangedEventHandler Windows.UI.Xaml.IWindow.SizeChanged;

        public event WindowVisibilityChangedEventHandler Windows.UI.Xaml.IWindow.VisibilityChanged;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Activate();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Close();

        public Rect Bounds { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public UIElement Content { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.UI.Core.CoreWindow CoreWindow { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static Window Current { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public CoreDispatcher Dispatcher { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Visible { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Rect Windows.UI.Xaml.IWindow.Bounds { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public UIElement Windows.UI.Xaml.IWindow.Content { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.UI.Core.CoreWindow Windows.UI.Xaml.IWindow.CoreWindow { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public CoreDispatcher Windows.UI.Xaml.IWindow.Dispatcher { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Xaml.IWindow.Visible { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

