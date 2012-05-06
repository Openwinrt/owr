namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Core;

    [Version(0x6020000), ExclusiveTo(typeof(Window)), Windows.Foundation.Metadata.Guid(0x3276167d, 0xc9f6, 0x462d, 0x9d, 0xe2, 0xae, 0x4c, 0x1f, 0xd8, 0xc2, 0xe5), WebHostHidden]
    internal interface IWindow
    {
        event WindowActivatedEventHandler Activated;

        event WindowClosedEventHandler Closed;

        event WindowSizeChangedEventHandler SizeChanged;

        event WindowVisibilityChangedEventHandler VisibilityChanged;

        void Activate();
        void Close();

        Rect Bounds { get; }

        UIElement Content { get; [param: In] set; }

        Windows.UI.Core.CoreWindow CoreWindow { get; }

        CoreDispatcher Dispatcher { get; }

        bool Visible { get; }
    }
}

