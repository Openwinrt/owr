namespace Windows.Web.Syndication
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum SyndicationErrorStatus
    {
        Unknown,
        MissingRequiredElement,
        MissingRequiredAttribute,
        InvalidXml,
        UnexpectedContent,
        UnsupportedFormat
    }
}

