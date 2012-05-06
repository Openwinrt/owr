namespace Windows.Security.ExchangeActiveSyncProvisioning
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class EasComplianceResults : IEasComplianceResults
    {
        public bool Compliant { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public EasDisallowConvenienceLogonResult DisallowConvenienceLogonResult { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public EasMaxInactivityTimeLockResult MaxInactivityTimeLockResult { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public EasMaxPasswordFailedAttemptsResult MaxPasswordFailedAttemptsResult { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public EasMinPasswordComplexCharactersResult MinPasswordComplexCharactersResult { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public EasMinPasswordLengthResult MinPasswordLengthResult { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public EasPasswordExpirationResult PasswordExpirationResult { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public EasPasswordHistoryResult PasswordHistoryResult { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public EasRequireEncryptionResult RequireEncryptionResult { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.Security.ExchangeActiveSyncProvisioning.IEasComplianceResults.Compliant { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public EasDisallowConvenienceLogonResult Windows.Security.ExchangeActiveSyncProvisioning.IEasComplianceResults.DisallowConvenienceLogonResult { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public EasMaxInactivityTimeLockResult Windows.Security.ExchangeActiveSyncProvisioning.IEasComplianceResults.MaxInactivityTimeLockResult { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public EasMaxPasswordFailedAttemptsResult Windows.Security.ExchangeActiveSyncProvisioning.IEasComplianceResults.MaxPasswordFailedAttemptsResult { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public EasMinPasswordComplexCharactersResult Windows.Security.ExchangeActiveSyncProvisioning.IEasComplianceResults.MinPasswordComplexCharactersResult { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public EasMinPasswordLengthResult Windows.Security.ExchangeActiveSyncProvisioning.IEasComplianceResults.MinPasswordLengthResult { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public EasPasswordExpirationResult Windows.Security.ExchangeActiveSyncProvisioning.IEasComplianceResults.PasswordExpirationResult { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public EasPasswordHistoryResult Windows.Security.ExchangeActiveSyncProvisioning.IEasComplianceResults.PasswordHistoryResult { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public EasRequireEncryptionResult Windows.Security.ExchangeActiveSyncProvisioning.IEasComplianceResults.RequireEncryptionResult { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

