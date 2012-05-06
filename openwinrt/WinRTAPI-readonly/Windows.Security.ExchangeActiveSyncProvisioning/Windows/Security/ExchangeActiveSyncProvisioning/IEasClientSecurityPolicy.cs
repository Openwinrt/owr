namespace Windows.Security.ExchangeActiveSyncProvisioning
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x45b72362, 0xdfba, 0x4a9b, 0xac, 0xed, 0x6f, 0xe2, 0xad, 0xcb, 100, 0x20), ExclusiveTo(typeof(EasClientSecurityPolicy))]
    internal interface IEasClientSecurityPolicy
    {
        ApplyAsyncOperation ApplyAsync();
        EasComplianceResults CheckCompliance();

        bool DisallowConvenienceLogon { get; [param: In] set; }

        Windows.Foundation.TimeSpan MaxInactivityTimeLock { get; [param: In] set; }

        byte MaxPasswordFailedAttempts { get; [param: In] set; }

        byte MinPasswordComplexCharacters { get; [param: In] set; }

        byte MinPasswordLength { get; [param: In] set; }

        Windows.Foundation.TimeSpan PasswordExpiration { get; [param: In] set; }

        uint PasswordHistory { get; [param: In] set; }

        bool RequireEncryption { get; [param: In] set; }
    }
}

