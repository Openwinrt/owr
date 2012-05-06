namespace Windows.UI.Text
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum LinkType
    {
        Undefined,
        NotALink,
        ClientLink,
        FriendlyLinkName,
        FriendlyLinkAddress,
        AutoLink,
        AutoLinkEmail,
        AutoLinkPhone,
        AutoLinkPath
    }
}

