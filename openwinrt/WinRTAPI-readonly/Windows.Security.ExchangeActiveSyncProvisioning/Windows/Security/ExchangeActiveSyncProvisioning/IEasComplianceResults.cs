namespace Windows.Security.ExchangeActiveSyncProvisioning
{
    using System;
    using Windows.Foundation.Metadata;

    [Guid(0x463c299c, 0x7f19, 0x4c66, 180, 3, 0xcb, 0x45, 0xdd, 0x57, 0xa2, 0xb3), Version(0x6020000), ExclusiveTo(typeof(EasComplianceResults))]
    internal interface IEasComplianceResults
    {
        bool Compliant { get; }

        EasDisallowConvenienceLogonResult DisallowConvenienceLogonResult { get; }

        EasMaxInactivityTimeLockResult MaxInactivityTimeLockResult { get; }

        EasMaxPasswordFailedAttemptsResult MaxPasswordFailedAttemptsResult { get; }

        EasMinPasswordComplexCharactersResult MinPasswordComplexCharactersResult { get; }

        EasMinPasswordLengthResult MinPasswordLengthResult { get; }

        EasPasswordExpirationResult PasswordExpirationResult { get; }

        EasPasswordHistoryResult PasswordHistoryResult { get; }

        EasRequireEncryptionResult RequireEncryptionResult { get; }
    }
}

