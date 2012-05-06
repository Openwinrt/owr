namespace Windows.Web
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum WebErrorStatus
    {
        BadGateway = 0x1f6,
        BadRequest = 400,
        CannotConnect = 14,
        CertificateCommonNameIsIncorrect = 1,
        CertificateContainsErrors = 3,
        CertificateExpired = 2,
        CertificateIsInvalid = 5,
        CertificateRevoked = 4,
        Conflict = 0x199,
        ConnectionAborted = 9,
        ConnectionReset = 10,
        Disconnected = 11,
        ErrorHttpInvalidServerResponse = 8,
        ExpectationFailed = 0x1a1,
        Forbidden = 0x193,
        Found = 0x12e,
        GatewayTimeout = 0x1f8,
        Gone = 410,
        HostNameNotResolved = 15,
        HttpsToHttpOnRedirection = 13,
        HttpToHttpsOnRedirection = 12,
        HttpVersionNotSupported = 0x1f9,
        InternalServerError = 500,
        LengthRequired = 0x19b,
        MethodNotAllowed = 0x195,
        MovedPermanently = 0x12d,
        MultipleChoices = 300,
        NotAcceptable = 0x196,
        NotFound = 0x194,
        NotImplemented = 0x1f5,
        NotModified = 0x130,
        OperationCanceled = 0x10,
        PaymentRequired = 0x192,
        PreconditionFailed = 0x19c,
        ProxyAuthenticationRequired = 0x197,
        RedirectFailed = 0x11,
        RequestedRangeNotSatisfiable = 0x1a0,
        RequestEntityTooLarge = 0x19d,
        RequestTimeout = 0x198,
        RequestUriTooLong = 0x19e,
        SeeOther = 0x12f,
        ServerUnreachable = 6,
        ServiceUnavailable = 0x1f7,
        TemporaryRedirect = 0x133,
        Timeout = 7,
        Unauthorized = 0x191,
        UnexpectedClientError = 20,
        UnexpectedRedirection = 0x13,
        UnexpectedServerError = 0x15,
        UnexpectedStatusCode = 0x12,
        Unknown = 0,
        UnsupportedMediaType = 0x19f,
        UseProxy = 0x131
    }
}

