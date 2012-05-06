namespace Windows.UI.ViewManagement
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x85361600, 0x1c63, 0x4627, 0xbc, 0xb1, 0x3a, 0x89, 0xe0, 0xbc, 0x9c, 0x55), ExclusiveTo(typeof(UISettings))]
    internal interface IUISettings
    {
        Color UIElementColor([In] UIElementType desiredElement);

        bool AnimationsEnabled { get; }

        uint CaretBlinkRate { get; }

        bool CaretBrowsingEnabled { get; }

        uint CaretWidth { get; }

        Size CursorSize { get; }

        uint DoubleClickTime { get; }

        Windows.UI.ViewManagement.HandPreference HandPreference { get; }

        uint MessageDuration { get; }

        uint MouseHoverTime { get; }

        Size ScrollBarArrowSize { get; }

        Size ScrollBarSize { get; }

        Size ScrollBarThumbBoxSize { get; }
    }
}

