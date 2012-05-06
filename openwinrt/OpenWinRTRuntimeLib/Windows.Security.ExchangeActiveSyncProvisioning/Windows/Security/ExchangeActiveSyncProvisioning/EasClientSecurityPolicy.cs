namespace Windows.Security.ExchangeActiveSyncProvisioning
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Threading(ThreadingModel.Both), Activatable(0x6020000)]
    public sealed class EasClientSecurityPolicy : IEasClientSecurityPolicy
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public EasClientSecurityPolicy();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ApplyAsyncOperation ApplyAsync();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public EasComplianceResults CheckCompliance();

        public bool DisallowConvenienceLogon { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.Foundation.TimeSpan MaxInactivityTimeLock { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public byte MaxPasswordFailedAttempts { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public byte MinPasswordComplexCharacters { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public byte MinPasswordLength { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.Foundation.TimeSpan PasswordExpiration { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public uint PasswordHistory { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool RequireEncryption { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.Security.ExchangeActiveSyncProvisioning.IEasClientSecurityPolicy.DisallowConvenienceLogon { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.Foundation.TimeSpan Windows.Security.ExchangeActiveSyncProvisioning.IEasClientSecurityPolicy.MaxInactivityTimeLock { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public byte Windows.Security.ExchangeActiveSyncProvisioning.IEasClientSecurityPolicy.MaxPasswordFailedAttempts { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public byte Windows.Security.ExchangeActiveSyncProvisioning.IEasClientSecurityPolicy.MinPasswordComplexCharacters { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public byte Windows.Security.ExchangeActiveSyncProvisioning.IEasClientSecurityPolicy.MinPasswordLength { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.Foundation.TimeSpan Windows.Security.ExchangeActiveSyncProvisioning.IEasClientSecurityPolicy.PasswordExpiration { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public uint Windows.Security.ExchangeActiveSyncProvisioning.IEasClientSecurityPolicy.PasswordHistory { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.Security.ExchangeActiveSyncProvisioning.IEasClientSecurityPolicy.RequireEncryption { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

