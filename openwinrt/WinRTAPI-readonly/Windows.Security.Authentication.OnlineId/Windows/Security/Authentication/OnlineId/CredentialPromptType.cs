namespace Windows.Security.Authentication.OnlineId
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum CredentialPromptType
    {
        PromptIfNeeded,
        RetypeCredentials,
        DoNotPrompt
    }
}

