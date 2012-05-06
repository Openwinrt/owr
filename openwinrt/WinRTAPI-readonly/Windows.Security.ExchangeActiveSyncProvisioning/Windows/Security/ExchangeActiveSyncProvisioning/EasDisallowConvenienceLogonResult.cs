namespace Windows.Security.ExchangeActiveSyncProvisioning
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum EasDisallowConvenienceLogonResult
    {
        NotEvaluated,
        Compliant,
        CanBeCompliant,
        RequestedPolicyIsStricter
    }
}

