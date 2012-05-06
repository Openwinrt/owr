namespace Windows.Security.ExchangeActiveSyncProvisioning
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum EasPasswordExpirationResult
    {
        NotEvaluated,
        Compliant,
        CanBeCompliant,
        RequestedPolicyIsStricter,
        RequestedExpirationIncompatible,
        InvalidParameter,
        UserCannotChangePassword,
        AdminsCannotChangePassword,
        LocalControlledUsersCannotChangePassword
    }
}

