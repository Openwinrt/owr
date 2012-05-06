namespace Windows.UI.ViewManagement
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI;

    [Version(0x6020000), Activatable(0x6020000)]
    public sealed class UISettings : IUISettings
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public UISettings();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Color UIElementColor([In] UIElementType desiredElement);

        public bool AnimationsEnabled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint CaretBlinkRate { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool CaretBrowsingEnabled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint CaretWidth { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Size CursorSize { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint DoubleClickTime { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.ViewManagement.HandPreference HandPreference { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint MessageDuration { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint MouseHoverTime { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Size ScrollBarArrowSize { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Size ScrollBarSize { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Size ScrollBarThumbBoxSize { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.ViewManagement.IUISettings.AnimationsEnabled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.UI.ViewManagement.IUISettings.CaretBlinkRate { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.ViewManagement.IUISettings.CaretBrowsingEnabled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.UI.ViewManagement.IUISettings.CaretWidth { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Size Windows.UI.ViewManagement.IUISettings.CursorSize { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.UI.ViewManagement.IUISettings.DoubleClickTime { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.ViewManagement.HandPreference Windows.UI.ViewManagement.IUISettings.HandPreference { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.UI.ViewManagement.IUISettings.MessageDuration { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.UI.ViewManagement.IUISettings.MouseHoverTime { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Size Windows.UI.ViewManagement.IUISettings.ScrollBarArrowSize { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Size Windows.UI.ViewManagement.IUISettings.ScrollBarSize { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Size Windows.UI.ViewManagement.IUISettings.ScrollBarThumbBoxSize { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

