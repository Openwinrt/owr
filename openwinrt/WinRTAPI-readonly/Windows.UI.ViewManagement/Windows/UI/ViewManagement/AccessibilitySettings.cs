namespace Windows.UI.ViewManagement
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Activatable(0x6020000)]
    public sealed class AccessibilitySettings : IAccessibilitySettings
    {
        public event TypedEventHandler<AccessibilitySettings, object> HighContrastChanged;

        public event TypedEventHandler<AccessibilitySettings, object> Windows.UI.ViewManagement.IAccessibilitySettings.HighContrastChanged;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public AccessibilitySettings();

        public bool HighContrast { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string HighContrastScheme { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.ViewManagement.IAccessibilitySettings.HighContrast { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.UI.ViewManagement.IAccessibilitySettings.HighContrastScheme { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

