namespace Windows.UI.ViewManagement
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(AccessibilitySettings)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0xfe0e8147, 0xc4c0, 0x4562, 0xb9, 0x62, 0x13, 0x27, 0xb5, 0x2a, 0xd5, 0xb9)]
    internal interface IAccessibilitySettings
    {
        event TypedEventHandler<AccessibilitySettings, object> HighContrastChanged;

        bool HighContrast { get; }

        string HighContrastScheme { get; }
    }
}

