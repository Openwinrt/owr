namespace Windows.Security.ExchangeActiveSyncProvisioning
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum EasMinPasswordComplexCharactersResult
    {
        NotEvaluated,
        Compliant,
        CanBeCompliant,
        RequestedPolicyIsStricter,
        RequestedPolicyNotEnforceable,
        InvalidParameter,
        CurrentUserHasBlankPassword,
        AdminsHaveBlankPassword,
        UserCannotChangePassword,
        AdminsCannotChangePassword,
        LocalControlledUsersCannotChangePassword
    }
}

