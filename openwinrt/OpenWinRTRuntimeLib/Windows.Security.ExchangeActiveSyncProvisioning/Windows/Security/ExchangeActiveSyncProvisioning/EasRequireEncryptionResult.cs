namespace Windows.Security.ExchangeActiveSyncProvisioning
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum EasRequireEncryptionResult
    {
        NotEvaluated,
        Compliant,
        CanBeCompliant,
        NotProvisionedOnAllVolumes,
        DeFixedDataNotSupported,
        DeHardwareNotCompliant,
        DeWinReNotConfigured,
        DeProtectionSuspended,
        DeOsVolumeNotProtected,
        DeProtectionNotYetEnabled,
        NoFeatureLicense,
        OsNotProtected
    }
}

