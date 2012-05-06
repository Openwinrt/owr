﻿namespace Windows.Security.ExchangeActiveSyncProvisioning
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum EasMaxInactivityTimeLockResult
    {
        NotEvaluated,
        Compliant,
        CanBeCompliant,
        RequestedPolicyIsStricter,
        InvalidParameter
    }
}

