namespace Windows.UI.Notifications
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum NotificationSetting
    {
        Enabled,
        DisabledForApplication,
        DisabledForUser,
        DisabledByGroupPolicy,
        DisabledByManifest
    }
}

